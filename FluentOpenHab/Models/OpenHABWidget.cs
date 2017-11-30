using System.Collections.Generic;

namespace FluentOpenHab.Models
{
    public class OpenHABWidget
    {
        public int ColSpan { get; set; } = 1;
        public int RowSpan { get; set; } = 1;

        public double CalculateHeight(int height) => height * RowSpan;
        public double CalculateWidth(int width) => width * ColSpan;

        /// <summary>
        /// Gets or sets the ID of the OpenHAB widget
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Type of the OpenHAB widget
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the Label of the OpenHAB widget
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the Item of the OpenHAB widget
        /// </summary>
        public OpenHABItem Item { get; set; }

        /// <summary>
        /// Gets or sets the Encoding of the OpenHAB widget
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets the Children of the OpenHAB widget
        /// </summary>
        public ICollection<OpenHABWidget> Children { get; set; }

        /// <summary>
        /// Gets or sets the Mapping of the OpenHAB widget
        /// </summary>
        public ICollection<OpenHABWidgetMapping> Mappings { get; set; }
    }
}
