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
using csNgin.engine;

namespace csNgin.util
{
    public class objectNode
    {
        public int id       {get;set;}
        public vec2 pos     {get;set;}
        public object obj   {get;set;}
        public float width  {get;set;}
        public float height {get;set;}
        public int layer_i  {get;set;}  // z offset
        public string name  {get;set;}
        public int parentId {get;set;}

        public List<objectNode> children {get;set;}

        public objectNode(int _id, int _layer_i, string _name, int _parentId)
        {
            id = _id;
            pos = new vec2();
            layer_i = _layer_i;
            name = _name;
            parentId = _parentId;
        }

        public void insertChild(objectNode _child)
        {
            try{
                children.Add(_child);
                _child.parentId = id;
            }catch{
                // Debugger, notify issue at InsertChild ${name}
            }
        }

        public void removeChild(int _index)
        {
            children.RemoveAt(_index);
        }

        public string[] str_getChildren()
        {
            List<string> temp = new List<string>();
            foreach(objectNode x in children)
            {
                temp.Add($"{x.id} :: {x.name}\n");
            }
            return temp.ToArray();
        }

        // ##### RENDER ##### \\
    }
}