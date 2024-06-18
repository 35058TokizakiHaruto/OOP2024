﻿using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                Student studen = new Student() {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(studen);
            }
            return students;

        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (Student subject in _score) {
                if (dict.ContainsKey(subject.Name))
                    dict[subject.Name] += subject.Score;
                else
                    dict[subject.Name] = subject.Score;
            }

            return dict;

        }
    }
}
