using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        List<Customer> _customers;

        private byte[] _selectedImageData; //画像データのバイト配列

        public MainWindow() {
            InitializeComponent();
        }

        // Save Button: 顧客データを追加
        private void RegistButton_Click(object sender, RoutedEventArgs e) {
            if (_selectedImageData == null || _selectedImageData.Length == 0) {
                MessageBox.Show("画像が選択されていません。画像を選択してください。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AdressTextBox.Text,
                ImageData = _selectedImageData
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }

            ReadDatebase(); // ListViewに表示
        }

        // Update Button: 顧客情報の更新
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください");
                return;
            }

            // TextBoxの内容で選択された顧客情報を更新
            selectedCustomer.Name = NameTextBox.Text;
            selectedCustomer.Phone = PhoneTextBox.Text;
            selectedCustomer.Address = AdressTextBox.Text;
            selectedCustomer.ImageData = _selectedImageData;

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(selectedCustomer); // 顧客情報をデータベースで更新
            }

            ReadDatebase(); // ListViewに表示
        }

        // データベースからデータを読み込んでListViewに表示
        private void ReadDatebase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = null;
                CustomerListView.ItemsSource = _customers;
            }
        }

        // Search TextBox: 名前でフィルタリング
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        // Delete Button: 顧客情報の削除
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item); // 顧客情報をデータベースから削除
            }

            ReadDatebase(); // ListViewに表示
        }

        // ウィンドウがロードされた時にデータを読み込む
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatebase();
        }

        // ListViewで選択された顧客をTextBoxに表示
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AdressTextBox.Text = selectedCustomer.Address;
            }
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e) {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true) {
                string selectedFilePath = openFileDialog.FileName;

                try {
                    // 画像をバイト配列として読み込む
                    _selectedImageData = File.ReadAllBytes(selectedFilePath);

                    // 画像を Image コントロールに表示
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(selectedFilePath, UriKind.Absolute);
                    bitmap.EndInit();

                    // ImageViewer コントロールに画像を設定 (XAMLのImageコントロール名に合わせる)
                    //ImageData.Source = bitmap;

                    MessageBox.Show($"選択された画像ファイル: {selectedFilePath}", "画像ファイルの選択", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex) {
                    // より詳細なエラーメッセージを表示
                    MessageBox.Show($"画像を読み込む際にエラーが発生しました: {ex.ToString()}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public class ByteArrayToImageConverter : IValueConverter {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
                if (value is byte[] imageData && imageData.Length > 0) {
                    using (var stream = new MemoryStream(imageData)) {
                        return new BitmapImage { StreamSource = stream };
                    }
                }
                return null;
            }
            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
                throw new NotImplementedException();
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AdressTextBox.Clear();
            SearchTextBox.Clear();

            _selectedImageData = null;
            //ImageData.Source = null;
        }
    }
}

