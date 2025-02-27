// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// The base class of a view which can take keyboard input.
    /// </summary>
    public abstract partial class InputView : View
    {
        static InputView()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value that indicates the number of device-independent units that should be in between characters in the text displayed by the Entry. Applies to Text and Placeholder.
        /// </summary>
        /// <value>
        /// The number of device-independent units that should be in between characters in the text.
        /// </value>
        [Parameter] public double? CharacterSpacing { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates whether user should be prevented from modifying the text. Default is <see langword="false" />.
        /// </summary>
        /// <value>
        /// If <see langword="true" />, user cannot modify text. Else, <see langword="false" />.
        /// </value>
        [Parameter] public bool? IsReadOnly { get; set; }
        /// <summary>
        /// Gets or sets a value that controls whether spell checking is enabled.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if spell checking is enabled. Otherwise <see langword="false" />.
        /// </value>
        [Parameter] public bool? IsSpellCheckEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Keyboard for the InputView.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.Maui.Keyboard" /> to use for the InputView.
        /// </value>
        [Parameter] public Keyboard Keyboard { get; set; }
        /// <summary>
        /// Gets or sets the maximum allowed length of input.
        /// </summary>
        /// <value>
        /// An integer in the interval [0,<c>int.MaxValue</c>]. The default value is <c>Int.MaxValue</c>.
        /// </value>
        [Parameter] public int? MaxLength { get; set; }
        /// <summary>
        /// Gets or sets the text that is displayed when the control is empty.
        /// </summary>
        /// <value>
        /// The text that is displayed when the control is empty.
        /// </value>
        [Parameter] public string Placeholder { get; set; }
        /// <summary>
        /// Gets or sets the color of the placeholder text.
        /// </summary>
        /// <value>
        /// The color of the placeholder text.
        /// </value>
        [Parameter] public Color PlaceholderColor { get; set; }
        /// <summary>
        /// Gets or sets the text color.
        /// </summary>
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public TextTransform? TextTransform { get; set; }

        public new MC.InputView NativeControl => (MC.InputView)((BindableObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(CharacterSpacing):
                    if (!Equals(CharacterSpacing, value))
                    {
                        CharacterSpacing = (double?)value;
                        NativeControl.CharacterSpacing = CharacterSpacing ?? (double)MC.InputView.CharacterSpacingProperty.DefaultValue;
                    }
                    break;
                case nameof(IsReadOnly):
                    if (!Equals(IsReadOnly, value))
                    {
                        IsReadOnly = (bool?)value;
                        NativeControl.IsReadOnly = IsReadOnly ?? (bool)MC.InputView.IsReadOnlyProperty.DefaultValue;
                    }
                    break;
                case nameof(IsSpellCheckEnabled):
                    if (!Equals(IsSpellCheckEnabled, value))
                    {
                        IsSpellCheckEnabled = (bool?)value;
                        NativeControl.IsSpellCheckEnabled = IsSpellCheckEnabled ?? (bool)MC.InputView.IsSpellCheckEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(Keyboard):
                    if (!Equals(Keyboard, value))
                    {
                        Keyboard = (Keyboard)value;
                        NativeControl.Keyboard = Keyboard;
                    }
                    break;
                case nameof(MaxLength):
                    if (!Equals(MaxLength, value))
                    {
                        MaxLength = (int?)value;
                        NativeControl.MaxLength = MaxLength ?? (int)MC.InputView.MaxLengthProperty.DefaultValue;
                    }
                    break;
                case nameof(Placeholder):
                    if (!Equals(Placeholder, value))
                    {
                        Placeholder = (string)value;
                        NativeControl.Placeholder = Placeholder;
                    }
                    break;
                case nameof(PlaceholderColor):
                    if (!Equals(PlaceholderColor, value))
                    {
                        PlaceholderColor = (Color)value;
                        NativeControl.PlaceholderColor = PlaceholderColor;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(TextTransform):
                    if (!Equals(TextTransform, value))
                    {
                        TextTransform = (TextTransform?)value;
                        NativeControl.TextTransform = TextTransform ?? (TextTransform)MC.InputView.TextTransformProperty.DefaultValue;
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
