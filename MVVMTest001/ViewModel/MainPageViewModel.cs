using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MVVMTest001.ViewModel
{
    public class MainPageViewModel:INotifyPropertyChanged
    {
        public MainPageViewModel() {
            AllNotes = new ObservableCollection<string>();
            EraseCommand = new Command(() => {
                TheNote = string.Empty; 
            });

            SaveCommand = new Command(() => {
                AllNotes.Add(TheNote);
                TheNote = string.Empty;
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;


        //the note
        string theNote;
        public string TheNote {
            get => theNote;
            set {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);
            }
        }


        //command 
        public ObservableCollection<string> AllNotes { get; set; }
        public Command SaveCommand { get; }
        public Command EraseCommand { get; }

    }
}
