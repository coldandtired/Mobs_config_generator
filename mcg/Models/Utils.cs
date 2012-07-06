using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using me.coldandtired.mcg.Models;
using Microsoft.Windows;

namespace me.coldandtired.mcg.Models
{
    public static class Utils
    {
        public static SelectionCollection get_dropped_item(Microsoft.Windows.DragEventArgs e)
        {
            var format = e.Data.GetFormats()[0];
            ItemDragEventArgs dragItem = e.Data.GetData(format) as ItemDragEventArgs;
            return dragItem.Data as SelectionCollection;
        }

        public static DragDropEffects block_bin_moving(Microsoft.Windows.DragEventArgs e)
        {
            SelectionCollection dropped = get_dropped_item(e);

            if (dropped.First().Item is Image)
            {
                Image image = (Image)dropped.First().Item;
                if (image.Name == "bin") return Microsoft.Windows.DragDropEffects.None;
            }
            return Microsoft.Windows.DragDropEffects.Copy;
        }
    }
}
