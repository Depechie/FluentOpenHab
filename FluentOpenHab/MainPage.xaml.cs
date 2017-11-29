using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace FluentOpenHab
{
    public class OpenHabThing
    {
        public string Title { get; set; }
        public int Width { get; set; } = 1;
        public int Height { get; set; } = 1;

        public double CalculateHeight(int height) => height * Height;
        public double CalculateWidth(int width) => width * Width;

    }

    public sealed partial class MainPage : Page
    {
        public List<OpenHabThing> Items { get; set; } = new List<OpenHabThing>()
        {
            new OpenHabThing() { Title = "First floor", Height = 2 },
            new OpenHabThing() { Title = "Second floor", Width = 2 }
        };

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }
    }
}
