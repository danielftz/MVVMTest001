using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MVVMTest001.ViewModel;

namespace MVVMTest001.View
{
    public class MainPage:ContentPage
    {
        public MainPage() {
            BindingContext = new MainPageViewModel();

            
            Editor noteEditor = new Editor { HeightRequest = 200 };
            noteEditor.SetBinding(Editor.TextProperty, "TheNote");

            Label noteDisplay = new Label { FontSize = 20, };
            noteDisplay.SetBinding(Label.TextProperty, "TheNote");

            Button deleteButton = new Button {
                BackgroundColor = Color.Red,
                Text = "Delete"
            };
            deleteButton.SetBinding(Button.CommandProperty, "EraseCommand");
            

            Content = new StackLayout {
                Margin = new Thickness(20),
                Children = {
                    noteEditor,
                    new Button {
                        BackgroundColor = Color.Green,
                        Text = "Save",
                    },
                    deleteButton,
                    noteDisplay

                },
            };

        }
    }
}
