using Xamarin.Forms;

namespace makeHabit
{
    public class DayButton : Button
    {
        enum StatusType { close = 0, open, complete };

        StatusType status = StatusType.close;
        string open_text;

        public DayButton(string text) {
            open_text = text;
            Text = "close";
            BackgroundColor = Color.Aqua;
        }

        public void next() {
            status = status + 1;
            changeDisplay();
        }

        private void changeDisplay() {
            if (status == StatusType.close) {
                Text = "close";
            } else if (status == StatusType.open) {
                Text = open_text;
            } else {
                Text = "complete";
            }
        }
    }
}
