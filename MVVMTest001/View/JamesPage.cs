using System;
using System.Collections.Generic;
using System.Text;
using MVVMTest001.ViewModel;
using Xamarin.Forms;

namespace MVVMTest001.View
{
    public class JamesPage:ContentPage
    {
        public JamesPage() {
            BindingContext = new JamesPageViewModel();

            //initilaize stacklayout children
            //you're fucked if you type in the path string wrong!
            Editor noteEditor = new Editor { HeightRequest = 200 };
            noteEditor.SetBinding(Editor.TextProperty, "TheNote");

            Label noteDisplay = new Label { FontSize = 20, };
            noteDisplay.SetBinding(Label.TextProperty, "TheNote");

            Button deleteButton = new Button {
                BackgroundColor = Color.Red,
                Text = "Delete"
            };
            deleteButton.SetBinding(Button.CommandProperty, "EraseCommand");

            //content of stacklayout
            Content = new StackLayout {
                Margin = new Thickness(20),
                Children = {
                    new Label{Text="James Page"},
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
