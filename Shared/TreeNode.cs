using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewProject.Shared
{
    public class TreeNode
    {
        public TreeNode(int id , string nodeText , bool isSelected)
        {
            Id = id;
            NodeText = nodeText;
            IsSelected = isSelected;
            ChildNodes = new List<TreeNode>();
        }

        public TreeNode(int id , string nodeText, bool isSelected , List<TreeNode> childNodes)
        {
            Id = id;
            NodeText = nodeText;
            IsSelected = isSelected;
            ChildNodes = childNodes;
        }

        public int Id { get; set; }
        public string NodeText { get; set; }
        public List<TreeNode> ChildNodes { get; set; }
        public bool IsSelected { get; set; } = true;
    }
}
