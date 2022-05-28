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

using csNgin.util;

namespace csNgin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            objectNode main = new objectNode(0, 0, "main", 0);
            Button mainBtn = new Button();
            mainBtn.Content = "main";
            main.obj = mainBtn;
            objectNode child = new objectNode(1, 1, "child", 0);
            Button childBtn = new Button();
            childBtn.Content = "child";
            child.obj = childBtn;

            world.objects.Add(main);
            world.objects.Add(child);
            world.updateRenderBuffer();

            foreach(var item in world.renderBuffer)
            {
                canvas.Children.Add((Button)item.obj);
            }
        }
    }
}
