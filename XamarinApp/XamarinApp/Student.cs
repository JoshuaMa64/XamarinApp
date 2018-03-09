using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp
{
    class Student
    {
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }

        private string Name { get; set; }
        private int Score { get; set; }
    }
}
