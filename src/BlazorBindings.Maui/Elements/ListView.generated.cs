// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// An <see cref="T:Microsoft.Maui.Controls.ItemsView`1" /> that displays a collection of data as a vertical list.
    /// </summary>
    public partial class ListView<T> : View
    {
        static ListView()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the binding to use for displaying the group header.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.Maui.Controls.BindingBase" /> instance to apply to grouped lists, or <see langword="null" />.
        /// </value>
        [Parameter] public Func<T, string> GroupDisplayBinding { get; set; }
        /// <summary>
        /// Gets or sets a binding for the name to display in grouped jump lists.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.Maui.Controls.BindingBase" /> instance to apply to grouped lists, or <see langword="null" />.
        /// </value>
        [Parameter] public Func<T, string> GroupShortNameBinding { get; set; }
        /// <summary>
        /// Gets or sets a Boolean value that indicates whether this <see cref="T:Microsoft.Maui.Controls.ListView" /> element has uneven rows.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if this <see cref="T:Microsoft.Maui.Controls.ListView" /> control has uneven rows. Otherwise, <see langword="false" />
        /// </value>
        [Parameter] public bool? HasUnevenRows { get; set; }
        [Parameter] public ScrollBarVisibility? HorizontalScrollBarVisibility { get; set; }
        /// <summary>
        /// Gets or sets whether or not grouping is enabled for <see cref="T:Microsoft.Maui.Controls.ListView" />.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if grouping is enabled, <see langword="false" /> otherwise and by default.
        /// </value>
        [Parameter] public bool? IsGroupingEnabled { get; set; }
        /// <summary>
        /// Gets or sets a value that tells whether the user can swipe down to cause the application to refresh.
        /// </summary>
        [Parameter] public bool? IsPullToRefreshEnabled { get; set; }
        /// <summary>
        /// Gets or sets a value that tells whether the list view is currently refreshing.
        /// </summary>
        [Parameter] public bool? IsRefreshing { get; set; }
        [Parameter] public IEnumerable<T> ItemsSource { get; set; }
        [Parameter] public Color RefreshControlColor { get; set; }
        /// <summary>
        /// Gets or sets a value that represents the height of a row.
        /// </summary>
        [Parameter] public int? RowHeight { get; set; }
        /// <summary>
        /// Gets or sets a value that controls whether and how many items can be selected.
        /// </summary>
        /// <value>
        /// <see cref="F:Microsoft.Maui.Controls.ListViewSelectionMode.None" /> if no selections can be made. <see cref="F:Microsoft.Maui.Controls.ListViewSelectionMode.Single" /> if one selection can be made.
        /// </value>
        [Parameter] public MC.ListViewSelectionMode? SelectionMode { get; set; }
        /// <summary>
        /// Gets or sets the color of the bar that separates list items.
        /// </summary>
        [Parameter] public Color SeparatorColor { get; set; }
        /// <summary>
        /// Gets or sets a value that tells whether separators are visible between items.
        /// </summary>
        [Parameter] public MC.SeparatorVisibility? SeparatorVisibility { get; set; }
        [Parameter] public ScrollBarVisibility? VerticalScrollBarVisibility { get; set; }
        /// <summary>
        /// Gets or sets a data template to use to format a data object for display at the bottom of the list view.
        /// </summary>
        [Parameter] public RenderFragment Footer { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="T:Microsoft.Maui.Controls.DataTemplate" /> for group headers.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.Maui.Controls.DataTemplate" /> for group headers, or <see langword="null" />.
        /// </value>
        [Parameter] public RenderFragment<object> GroupHeaderTemplate { get; set; }
        /// <summary>
        /// Gets or sets a data template to use to format a data object for display at the top of the list view.
        /// </summary>
        [Parameter] public RenderFragment Header { get; set; }
        [Parameter] public EventCallback<MC.ItemVisibilityEventArgs> OnItemAppearing { get; set; }
        [Parameter] public EventCallback<MC.ItemVisibilityEventArgs> OnItemDisappearing { get; set; }
        [Parameter] public EventCallback<MC.SelectedItemChangedEventArgs> OnItemSelected { get; set; }
        [Parameter] public EventCallback<MC.ItemTappedEventArgs> OnItemTapped { get; set; }
        [Parameter] public EventCallback<MC.ScrolledEventArgs> OnScrolled { get; set; }
        [Parameter] public EventCallback<bool> IsRefreshingChanged { get; set; }

        public new MC.ListView NativeControl => (MC.ListView)((BindableObject)this).NativeControl;

        protected override MC.ListView CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(GroupDisplayBinding):
                    if (!Equals(GroupDisplayBinding, value))
                    {
                        GroupDisplayBinding = (Func<T, string>)value;
                        NativeControl.GroupDisplayBinding = AttributeHelper.GetBinding(GroupDisplayBinding);
                    }
                    break;
                case nameof(GroupShortNameBinding):
                    if (!Equals(GroupShortNameBinding, value))
                    {
                        GroupShortNameBinding = (Func<T, string>)value;
                        NativeControl.GroupShortNameBinding = AttributeHelper.GetBinding(GroupShortNameBinding);
                    }
                    break;
                case nameof(HasUnevenRows):
                    if (!Equals(HasUnevenRows, value))
                    {
                        HasUnevenRows = (bool?)value;
                        NativeControl.HasUnevenRows = HasUnevenRows ?? (bool)MC.ListView.HasUnevenRowsProperty.DefaultValue;
                    }
                    break;
                case nameof(HorizontalScrollBarVisibility):
                    if (!Equals(HorizontalScrollBarVisibility, value))
                    {
                        HorizontalScrollBarVisibility = (ScrollBarVisibility?)value;
                        NativeControl.HorizontalScrollBarVisibility = HorizontalScrollBarVisibility ?? (ScrollBarVisibility)MC.ListView.HorizontalScrollBarVisibilityProperty.DefaultValue;
                    }
                    break;
                case nameof(IsGroupingEnabled):
                    if (!Equals(IsGroupingEnabled, value))
                    {
                        IsGroupingEnabled = (bool?)value;
                        NativeControl.IsGroupingEnabled = IsGroupingEnabled ?? (bool)MC.ListView.IsGroupingEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(IsPullToRefreshEnabled):
                    if (!Equals(IsPullToRefreshEnabled, value))
                    {
                        IsPullToRefreshEnabled = (bool?)value;
                        NativeControl.IsPullToRefreshEnabled = IsPullToRefreshEnabled ?? (bool)MC.ListView.IsPullToRefreshEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(IsRefreshing):
                    if (!Equals(IsRefreshing, value))
                    {
                        IsRefreshing = (bool?)value;
                        NativeControl.IsRefreshing = IsRefreshing ?? (bool)MC.ListView.IsRefreshingProperty.DefaultValue;
                    }
                    break;
                case nameof(ItemsSource):
                    if (!Equals(ItemsSource, value))
                    {
                        ItemsSource = (IEnumerable<T>)value;
                        NativeControl.ItemsSource = ItemsSource;
                    }
                    break;
                case nameof(RefreshControlColor):
                    if (!Equals(RefreshControlColor, value))
                    {
                        RefreshControlColor = (Color)value;
                        NativeControl.RefreshControlColor = RefreshControlColor;
                    }
                    break;
                case nameof(RowHeight):
                    if (!Equals(RowHeight, value))
                    {
                        RowHeight = (int?)value;
                        NativeControl.RowHeight = RowHeight ?? (int)MC.ListView.RowHeightProperty.DefaultValue;
                    }
                    break;
                case nameof(SelectionMode):
                    if (!Equals(SelectionMode, value))
                    {
                        SelectionMode = (MC.ListViewSelectionMode?)value;
                        NativeControl.SelectionMode = SelectionMode ?? (MC.ListViewSelectionMode)MC.ListView.SelectionModeProperty.DefaultValue;
                    }
                    break;
                case nameof(SeparatorColor):
                    if (!Equals(SeparatorColor, value))
                    {
                        SeparatorColor = (Color)value;
                        NativeControl.SeparatorColor = SeparatorColor;
                    }
                    break;
                case nameof(SeparatorVisibility):
                    if (!Equals(SeparatorVisibility, value))
                    {
                        SeparatorVisibility = (MC.SeparatorVisibility?)value;
                        NativeControl.SeparatorVisibility = SeparatorVisibility ?? (MC.SeparatorVisibility)MC.ListView.SeparatorVisibilityProperty.DefaultValue;
                    }
                    break;
                case nameof(VerticalScrollBarVisibility):
                    if (!Equals(VerticalScrollBarVisibility, value))
                    {
                        VerticalScrollBarVisibility = (ScrollBarVisibility?)value;
                        NativeControl.VerticalScrollBarVisibility = VerticalScrollBarVisibility ?? (ScrollBarVisibility)MC.ListView.VerticalScrollBarVisibilityProperty.DefaultValue;
                    }
                    break;
                case nameof(Footer):
                    Footer = (RenderFragment)value;
                    break;
                case nameof(GroupHeaderTemplate):
                    GroupHeaderTemplate = (RenderFragment<object>)value;
                    break;
                case nameof(Header):
                    Header = (RenderFragment)value;
                    break;
                case nameof(OnItemAppearing):
                    if (!Equals(OnItemAppearing, value))
                    {
                        void NativeControlItemAppearing(object sender, MC.ItemVisibilityEventArgs e) => InvokeEventCallback(OnItemAppearing, e);

                        OnItemAppearing = (EventCallback<MC.ItemVisibilityEventArgs>)value;
                        NativeControl.ItemAppearing -= NativeControlItemAppearing;
                        NativeControl.ItemAppearing += NativeControlItemAppearing;
                    }
                    break;
                case nameof(OnItemDisappearing):
                    if (!Equals(OnItemDisappearing, value))
                    {
                        void NativeControlItemDisappearing(object sender, MC.ItemVisibilityEventArgs e) => InvokeEventCallback(OnItemDisappearing, e);

                        OnItemDisappearing = (EventCallback<MC.ItemVisibilityEventArgs>)value;
                        NativeControl.ItemDisappearing -= NativeControlItemDisappearing;
                        NativeControl.ItemDisappearing += NativeControlItemDisappearing;
                    }
                    break;
                case nameof(OnItemSelected):
                    if (!Equals(OnItemSelected, value))
                    {
                        void NativeControlItemSelected(object sender, MC.SelectedItemChangedEventArgs e) => InvokeEventCallback(OnItemSelected, e);

                        OnItemSelected = (EventCallback<MC.SelectedItemChangedEventArgs>)value;
                        NativeControl.ItemSelected -= NativeControlItemSelected;
                        NativeControl.ItemSelected += NativeControlItemSelected;
                    }
                    break;
                case nameof(OnItemTapped):
                    if (!Equals(OnItemTapped, value))
                    {
                        void NativeControlItemTapped(object sender, MC.ItemTappedEventArgs e) => InvokeEventCallback(OnItemTapped, e);

                        OnItemTapped = (EventCallback<MC.ItemTappedEventArgs>)value;
                        NativeControl.ItemTapped -= NativeControlItemTapped;
                        NativeControl.ItemTapped += NativeControlItemTapped;
                    }
                    break;
                case nameof(OnScrolled):
                    if (!Equals(OnScrolled, value))
                    {
                        void NativeControlScrolled(object sender, MC.ScrolledEventArgs e) => InvokeEventCallback(OnScrolled, e);

                        OnScrolled = (EventCallback<MC.ScrolledEventArgs>)value;
                        NativeControl.Scrolled -= NativeControlScrolled;
                        NativeControl.Scrolled += NativeControlScrolled;
                    }
                    break;
                case nameof(IsRefreshingChanged):
                    if (!Equals(IsRefreshingChanged, value))
                    {
                        void NativeControlRefreshing(object sender, EventArgs e)
                        {
                            var value = NativeControl.IsRefreshing;
                            IsRefreshing = value;
                            InvokeEventCallback(IsRefreshingChanged, value);
                        }

                        IsRefreshingChanged = (EventCallback<bool>)value;
                        NativeControl.Refreshing -= NativeControlRefreshing;
                        NativeControl.Refreshing += NativeControlRefreshing;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.ListView>(builder, sequence++, Footer, (x, template) => x.FooterTemplate = template);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.ListView, object>(builder, sequence++, GroupHeaderTemplate, (x, template) => x.GroupHeaderTemplate = template);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.ListView>(builder, sequence++, Header, (x, template) => x.HeaderTemplate = template);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
