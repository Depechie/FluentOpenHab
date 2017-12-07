using FluentOpenHab.Models;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace FluentOpenHab
{
    public sealed partial class MainPage : Page
    {
        public List<OpenHABWidget> Groups { get; set; } = new List<OpenHABWidget>();

        public MainPage()
        {
            this.InitializeComponent();

            Groups.Add(new OpenHABWidget()
            {
                Label = "Group 1",
                Children = new List<OpenHABWidget>()
                {
                    new OpenHABWidget() { Label = "Item 1", Type = WidgetTypeEnum.Mapview.ToString(), ColSpan = 2, RowSpan = 2 },
                    new OpenHABWidget() { Label = "Item 2", Type = WidgetTypeEnum.Webview.ToString() },
                    new OpenHABWidget() { Label = "Item 3", Type = WidgetTypeEnum.Switch.ToString(), ColSpan = 2},
                    new OpenHABWidget() { Label = "Item 4", Type = WidgetTypeEnum.Switch.ToString(), ColSpan = 2}
                }
            });
/*
            Groups.Add(new OpenHABWidget()
            {
                Label = "Group 2",
                Children = new List<OpenHABWidget>()
                {
                    new OpenHABWidget() { Label = "Item 1" },
                    new OpenHABWidget() { Label = "Item 2", ColSpan = 2 },
                    new OpenHABWidget() { Label = "Item 3", ColSpan = 2, RowSpan = 2 },
                    new OpenHABWidget() { Label = "Item 4" },
                    new OpenHABWidget() { Label = "Item 5", ColSpan = 2, RowSpan = 2 },
                    new OpenHABWidget() { Label = "Item 6", ColSpan = 2 }
                }
            });

            Groups.Add(new OpenHABWidget()
            {
                Label = "Group 3",
                Children = new List<OpenHABWidget>()
                {
                    new OpenHABWidget() { Label = "Item 1", ColSpan = 2, RowSpan = 2 },
                    new OpenHABWidget() { Label = "Item 2", ColSpan = 2 },
                    new OpenHABWidget() { Label = "Item 3", ColSpan = 2, RowSpan = 2 },
                    new OpenHABWidget() { Label = "Item 4" },
                    new OpenHABWidget() { Label = "Item 5" },
                    new OpenHABWidget() { Label = "Item 6", ColSpan = 2 }
                }
            });
*/
            this.DataContext = this;
        }
    }
}
