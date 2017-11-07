using Xamarin.Forms;
using System;

namespace makeHabit
{
    public partial class MakeHabitPage : ContentPage
    {
        public MakeHabitPage(string title, DateTime startDate) {
            InitializeComponent();
            mainLabel.Text = title;
            mainLabel.Text += startDate;
        }
    }
}
