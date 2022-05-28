using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Collections.ObjectModel;
using csNgin.util;

namespace csNgin.engine
{
    public static class world
    {
        public static vec2 width_height = new vec2();
        public static ObservableCollection<objectNode> objects;
        public static ObservableCollection<objectNode> renderBuffer;
        static world()
        {
            objects      = new ObservableCollection<objectNode>();
        }

        private static ObservableCollection<objectNode> sortLayers(ObservableCollection<objectNode> _x)
        {
            Dictionary<int, objectNode> sorted = new Dictionary<int, objectNode>();
            foreach (objectNode obj in _x)
            {
                if (sorted.ContainsKey(obj.layer_i)) { sorted.Add(obj.layer_i, obj); }
                else { sorted.Add(obj.layer_i, obj); }
            }

            ObservableCollection<objectNode> toRet = new ObservableCollection<objectNode>();

            foreach(objectNode obj in sorted.Values)
            {
                obj.pos = transform.subtract(width_height, obj.pos);
                toRet.Add(obj);
            }
            return toRet;
        }

        public static void updateRenderBuffer()
        {
            renderBuffer = sortLayers(objects);
        }
    }
}
