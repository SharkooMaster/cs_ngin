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

namespace csNgin.util
{
    public class objectNode
    {
        public int id       {get;set;}
        public string name  {get;set;}
        public int parentId {get;set;}

        public List<objectNode> children {get;set;}

        public void insertChild(objectNode _child)
        {
            try{
                children.Add(_child);
                _child.parentId = id;
            }catch{
                // Debugger, notify issue at InsertChild ${name}
            }
        }
    }
}