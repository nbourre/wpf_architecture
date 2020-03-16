using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SchoolManagement.UI.Helpers
{
    /// <summary>
    /// Classe permettant d'attacher une nouvelle propriété SelectingItem aux contrôles
    /// Si vous désirez en savoir plus, lisez sur les Dependancy Property
    /// Pour l'instant ce sujet sort du cadre du cours.
    /// </summary>
    class SelectingItemAttachedProperty
    {
        public static readonly DependencyProperty SelectingItemProperty = DependencyProperty.RegisterAttached(
            "SelectingItem",
            typeof(Object),
            typeof(SelectingItemAttachedProperty),
            new PropertyMetadata(default(Object), OnSelectingItemChanged));

        public static Object GetSelectingItem(DependencyObject target)
        {
            return (Object)target.GetValue(SelectingItemProperty);
        }

        public static void SetSelectingItem(DependencyObject target, Object value)
        {
            target.SetValue(SelectingItemProperty, value);
        }

        static void OnSelectingItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            if (grid == null || grid.SelectedItem == null)
                return;

            // Works with .Net 4.5
            grid.Dispatcher.InvokeAsync(() =>
            {
                grid.UpdateLayout();

                if (grid.SelectedItem != null)
                    grid.ScrollIntoView(grid.SelectedItem, null);
            });

            // Works with .Net 4.0
            grid.Dispatcher.BeginInvoke((Action)(() =>
            {
                grid.UpdateLayout();

                if (grid.SelectedItem != null)
                    grid.ScrollIntoView(grid.SelectedItem, null);
            }));
        }
    }
}
