// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// A <see cref="T:Microsoft.Maui.Controls.Cell" /> with primary <see cref="P:Microsoft.Maui.Controls.TextCell.Text" /> and <see cref="P:Microsoft.Maui.Controls.TextCell.Detail" /> text.
    /// </summary>
    public partial class TextCell : Cell
    {
        static TextCell()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the secondary text to be displayed in the TextCell.
        /// </summary>
        [Parameter] public string Detail { get; set; }
        /// <summary>
        /// Gets or sets the color to render the secondary text.
        /// </summary>
        /// <value>
        /// The color of the text. Color.Default is the default color value.
        /// </value>
        [Parameter] public Color DetailColor { get; set; }
        /// <summary>
        /// Gets or sets the primary text to be displayed.
        /// </summary>
        [Parameter] public string Text { get; set; }
        /// <summary>
        /// Gets or sets the color to render the primary text.
        /// </summary>
        /// <value>
        /// The color of the text.
        /// </value>
        [Parameter] public Color TextColor { get; set; }

        public new MC.TextCell NativeControl => (MC.TextCell)((BindableObject)this).NativeControl;

        protected override MC.TextCell CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Detail):
                    if (!Equals(Detail, value))
                    {
                        Detail = (string)value;
                        NativeControl.Detail = Detail;
                    }
                    break;
                case nameof(DetailColor):
                    if (!Equals(DetailColor, value))
                    {
                        DetailColor = (Color)value;
                        NativeControl.DetailColor = DetailColor;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
