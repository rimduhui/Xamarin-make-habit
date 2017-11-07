using Xamarin.Forms;
using System;

namespace makeHabit
{
    public class Habit : Grid
    {
        public Habit()
        {
            BackgroundColor = Color.AliceBlue;

            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;

            RowDefinitions = new RowDefinitionCollection() {
                new RowDefinition { Height = GridLength.Auto }
           };

            ColumnDefinitions = new ColumnDefinitionCollection() {
                new ColumnDefinition { Width = GridLength.Auto }
            };

            for (int i = 1; i <= 6; i++) {
                for (int j = 0; j < 11; j++) {
                    var button = new DayButton("Lv." + (j * 6 + i));
                    button.Clicked += OnButtonClicked;
                    Children.Add(button, i, j);
                }
            }
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            ((DayButton)sender).next();
        }
    }
}
