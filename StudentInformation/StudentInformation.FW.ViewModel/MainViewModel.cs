using StudentInformation.FW.Model;
using StudentInformation.FW.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.FW.ViewModel
{
    public class MainViewModel
    {
        public Student Student { get; set; }
        public MessageCommand DisplayMessageCommand { get; set; }

        public MainViewModel()
        {
            Student = new Student("Neil", "Gaiman", 33);
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }
        public void DisplayMessage(string message)
        {
            Debug.WriteLine(message);
        }
        public List<String> GetStudents() 
        {
            return new List<string> { "Aram", "Arsen", "Ivan" };
        }
    }
}
