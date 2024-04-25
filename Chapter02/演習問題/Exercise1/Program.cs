using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class Program {
        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[]{
                new Song("Let it be","The Beatles",243),
                new Song("The Beatles","Troubled Water",293),
                new Song("Close To You","Careterns",275),
                new Song("Angel Hero","saikanomahotukai",293),
                new Song("Let It Go ","Jarner Fantagy Springs",293),



        };

        PrintSongs(songs);
    }
        //2.1.4
        private static void PrintSongs(Song[] songs) {


            foreach (var song in songs) {
                Console.WriteLine(@"{0}, {1} {2:mm\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
    

