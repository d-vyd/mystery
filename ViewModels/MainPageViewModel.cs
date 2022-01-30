using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using mystery;
using Prolog;

namespace ViewModels
{

    public class MainPageViewModel
    {
        private string _selectedcharacter;
        public string SelectedCharacter
        {
            get
            {
                return _selectedcharacter;
            }
            set
            {
                _selectedcharacter = value;
            }
        }

        private ObservableCollection<string> _characters;

       
        public ObservableCollection<string> Characters
        {
            get
            {
                if (_characters == null)
                    _characters = new ObservableCollection<string>();
                return _characters;
            }
            set
            {
                if (_characters != value)
                    _characters = value;
            }
        }

        public MainPageViewModel()

        {
            Console.WriteLine("\tMESSAGE:MainPageViewModel.cs constructor started.");
            List<string> solutionlist = Know.prolog["person(X)"];
            ObservableCollection<string> Characters = new ObservableCollection<string>(solutionlist);
            foreach (string c in Characters)
                Console.WriteLine("\t\t\t"+c);
            Console.WriteLine("\tMESSAGE:MainPageViewModel.cs constructor completed.");
        }
    }
}

