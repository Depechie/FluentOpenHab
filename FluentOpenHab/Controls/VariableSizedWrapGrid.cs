using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FluentOpenHab.Controls
{
    public class VariableSizedWrapGrid : GridView
    {
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            dynamic model = item; // alternative is implement an interface with both properties
            try
            {
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.ColumnSpanProperty, model.ColSpan);
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.RowSpanProperty, model.RowSpan);
            }
            catch
            {
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.ColumnSpanProperty, 1);
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.RowSpanProperty, 1);
            }
            finally
            {
                element.SetValue(PaddingProperty, new Thickness(0, 0, 5, 5));
                element.SetValue(VerticalContentAlignmentProperty, VerticalAlignment.Stretch);
                element.SetValue(HorizontalContentAlignmentProperty, HorizontalAlignment.Stretch);
                base.PrepareContainerForItemOverride(element, item);
            }
        }

        // refresh the variablesizedwrapgrid layout
        public void Update()
        {
            if (!(this.ItemsPanelRoot is Windows.UI.Xaml.Controls.VariableSizedWrapGrid))
                throw new ArgumentException("ItemsPanel is not VariableSizedWrapGrid");

            foreach (var container in this.ItemsPanelRoot.Children.Cast<GridViewItem>())
            {
                dynamic data = container.Content;
                Windows.UI.Xaml.Controls.VariableSizedWrapGrid.SetRowSpan(container, data?.RowSpan);
                Windows.UI.Xaml.Controls.VariableSizedWrapGrid.SetColumnSpan(container, data?.ColSpan);
            }

            this.ItemsPanelRoot.InvalidateMeasure();
        }
    }
}
