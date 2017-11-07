using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace makeHabit
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        void OnStartHabit(object sender, EventArgs e) {
            var title = editor.Text;
            var today = new DateTime();
            Navigation.PushModalAsync(new MakeHabitPage(title, today));
        }
    }
}
