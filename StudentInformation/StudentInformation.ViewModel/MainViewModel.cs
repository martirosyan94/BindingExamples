using StudentInformation.Model;
using StudentInformation.ViewModel.Commands;
using System.Diagnostics;

namespace StudentInformation.ViewModel
{
    public class MainViewModel
    {
        public Student Student { get; set; }
        public MessageCommand DisplayMessageCommand { get; set; }
        
        public MainViewModel()
        {
            Student = new Student("Neil","Gaiman", 33);
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }
        public void DisplayMessage(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
