using System;

namespace StudentInformation.Model
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public static readonly DependencyProperty IsSpinningProperty = DependencyProperty.Register("IsSpinning", typeof(bool), typeof(MainWindow)); 
        public bool IsSpinning { get => (bool)GetValue(IsSpinningProperty); set => SetValue(IsSpinningProperty, value); }
        public Student(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
    }
}
