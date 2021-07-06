using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMTest001.ViewModel
{
    public class JamesPageViewModel:BindableObject
    {
        public JamesPageViewModel() {
            EraseCommand = new Command(() => {
                TheNote = string.Empty;
            });
        }

        //the note
        string theNote;
        public string TheNote {
            get => theNote;
            set {
                theNote = value;
                OnPropertyChanged(nameof(TheNote));
            }
        }

        public ICommand EraseCommand { get; }
            
    }
}
