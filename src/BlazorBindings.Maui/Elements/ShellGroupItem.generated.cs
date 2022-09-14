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

namespace BlazorBindings.Maui.Elements
{
    public partial class ShellGroupItem : BaseShellItem
    {
        static ShellGroupItem()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.FlyoutDisplayOptions? FlyoutDisplayOptions { get; set; }

        public new MC.ShellGroupItem NativeControl => (MC.ShellGroupItem)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.ShellGroupItem();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutDisplayOptions):
                    if (!Equals(FlyoutDisplayOptions, value))
                    {
                        FlyoutDisplayOptions = (MC.FlyoutDisplayOptions?)value;
                        NativeControl.FlyoutDisplayOptions = FlyoutDisplayOptions ?? (MC.FlyoutDisplayOptions)MC.ShellGroupItem.FlyoutDisplayOptionsProperty.DefaultValue;
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
