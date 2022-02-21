using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentInformation.FW.Model
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set 
            { 
                _Age= value;
                PropertyChanged(this,new PropertyChangedEventArgs(nameof(Age)));
            }
        }

        public Student(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
    }
}
