using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace FluentOpenHab
{
    public class OpenHabThing
    {
        public string Title { get; set; }
        public int ColSpan { get; set; } = 1;
        public int RowSpan { get; set; } = 1;

        public double CalculateHeight(int height) => height * RowSpan;
        public double CalculateWidth(int width) => width * ColSpan;
    }

    public sealed partial class MainPage : Page
    {
        public List<OpenHabThing> Items { get; set; } = new List<OpenHabThing>()
        {
            new OpenHabThing() { Title = "First floor", RowSpan = 2 },
            new OpenHabThing() { Title = "Second floor", ColSpan = 2 },
            new OpenHabThing() { Title = "Second floor" },
            new OpenHabThing() { Title = "First floor", RowSpan = 2 },
            new OpenHabThing() { Title = "Second floor", ColSpan = 2 }
        };

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }
    }
}
