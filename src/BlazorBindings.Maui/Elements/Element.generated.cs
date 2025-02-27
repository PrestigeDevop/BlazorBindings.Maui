// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// Provides the base class for all Microsoft.Maui.Controls hierarchal elements. This class contains all the methods and properties required to represent an element in the Microsoft.Maui.Controls hierarchy.
    /// </summary>
    public abstract partial class Element : BindableObject
    {
        static Element()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value that allows the automation framework to find and interact with this element.
        /// </summary>
        /// <value>
        /// A value that the automation framework can use to find and interact with this element.
        /// </value>
        [Parameter] public string AutomationId { get; set; }
        /// <summary>
        /// Gets or sets a value used to identify a collection of semantically similar elements.
        /// </summary>
        /// <value>
        /// A string that represents the collection the element belongs to.
        /// </value>
        [Parameter] public string ClassId { get; set; }
        /// <summary>
        /// Gets or sets a user defined value to uniquely identify the element.
        /// </summary>
        /// <value>
        /// A string uniquely identifying the element.
        /// </value>
        [Parameter] public string StyleId { get; set; }

        public new MC.Element NativeControl => (MC.Element)((BindableObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AutomationId):
                    if (!Equals(AutomationId, value))
                    {
                        AutomationId = (string)value;
                        NativeControl.AutomationId = AutomationId;
                    }
                    break;
                case nameof(ClassId):
                    if (!Equals(ClassId, value))
                    {
                        ClassId = (string)value;
                        NativeControl.ClassId = ClassId;
                    }
                    break;
                case nameof(StyleId):
                    if (!Equals(StyleId, value))
                    {
                        StyleId = (string)value;
                        NativeControl.StyleId = StyleId;
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
