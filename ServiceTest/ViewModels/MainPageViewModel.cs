//using ServiceTest.Models;
//using ServiceTest.Services;
using ServiceTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ServiceTest.ViewModels
{
    public class MainPageViewModel:ViewModel
    {
        private string message;
        public string Message { get { return message; } set { message = value; OnPropertyChange(); } }
        public ICommand GetMessage { get; protected set; }
        public MainPageViewModel(TriviaService s)
        {
            triviaservice = s;

            GetMessage = new Command(async () => Message = await triviaservice.CheckConectionAsync());
        }

       


    }
}
