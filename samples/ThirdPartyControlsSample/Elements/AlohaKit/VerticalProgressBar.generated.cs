// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class VerticalProgressBar : BlazorBindings.Maui.Elements.GraphicsView
    {
        static VerticalProgressBar()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<VerticalProgressBar>(nameof(ProgressBrush),
                (renderer, parent, component) => new ContentPropertyHandler<AC.VerticalProgressBar>((x, value) => x.ProgressBrush = (MC.Brush)value));
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? Progress { get; set; }
        [Parameter] public AC.VerticalProgressBarDrawable ProgressBarDrawable { get; set; }
        [Parameter] public Color ProgressColor { get; set; }
        [Parameter] public RenderFragment ProgressBrush { get; set; }

        public new AC.VerticalProgressBar NativeControl => (AC.VerticalProgressBar)((BindableObject)this).NativeControl;

        protected override AC.VerticalProgressBar CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Progress):
                    if (!Equals(Progress, value))
                    {
                        Progress = (double?)value;
                        NativeControl.Progress = Progress ?? (double)AC.VerticalProgressBar.ProgressProperty.DefaultValue;
                    }
                    break;
                case nameof(ProgressBarDrawable):
                    if (!Equals(ProgressBarDrawable, value))
                    {
                        ProgressBarDrawable = (AC.VerticalProgressBarDrawable)value;
                        NativeControl.ProgressBarDrawable = ProgressBarDrawable;
                    }
                    break;
                case nameof(ProgressColor):
                    if (!Equals(ProgressColor, value))
                    {
                        ProgressColor = (Color)value;
                        NativeControl.ProgressBrush = ProgressColor;
                    }
                    break;
                case nameof(ProgressBrush):
                    ProgressBrush = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(VerticalProgressBar), ProgressBrush);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
