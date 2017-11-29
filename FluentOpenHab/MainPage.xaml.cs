using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace FluentOpenHab
{
    public class OpenHabGroup
    {
        public string Name { get; set; }
        public List<OpenHabThing> Items { get; set; }
    }

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
        public List<OpenHabGroup> Groups { get; set; } = new List<OpenHabGroup>();

        public MainPage()
        {
            this.InitializeComponent();

            Groups.Add(new OpenHabGroup()
            {
                Name = "Group 1",
                Items = new List<OpenHabThing>()
                {
                    new OpenHabThing() { Title = "Item 1", ColSpan = 2, RowSpan = 2 },
                    new OpenHabThing() { Title = "Item 2", ColSpan = 2 },
                    new OpenHabThing() { Title = "Item 3" },
                    new OpenHabThing() { Title = "Item 4", ColSpan = 2, RowSpan = 2 },
                    new OpenHabThing() { Title = "Item 5" },
                    new OpenHabThing() { Title = "Item 6", ColSpan = 2 }
                }
            });

            Groups.Add(new OpenHabGroup()
            {
                Name = "Group 2",
                Items = new List<OpenHabThing>()
                {
                    new OpenHabThing() { Title = "Item 1", ColSpan = 2, RowSpan = 2 },
                    new OpenHabThing() { Title = "Item 2", ColSpan = 2 },
                    new OpenHabThing() { Title = "Item 3" },
                    new OpenHabThing() { Title = "Item 4", ColSpan = 2, RowSpan = 2 },
                    new OpenHabThing() { Title = "Item 5" },
                    new OpenHabThing() { Title = "Item 6", ColSpan = 2 }
                }
            });

            this.DataContext = this;
        }
    }
}
