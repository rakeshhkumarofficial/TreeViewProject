using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewProject.Shared
{
    public class TreeNode
    {
        public int Id { get; set; }
        public string NodeText { get; set; }
        public bool IsSelected { get; set; }
        public int ParentNodeId { get; set; }
        public List<TreeNode> ChildNodes { get; set; }

        public TreeNode(int id , string nodeText , bool isSelected, int parentNodeId)
        {
            Id = id;
            NodeText = nodeText;
            IsSelected = isSelected;
            ParentNodeId = parentNodeId; 
            ChildNodes = new List<TreeNode>();
        }
        public TreeNode(int id , string nodeText, bool isSelected , int parentNodeId, List<TreeNode> childNodes)
        {
            Id = id;
            NodeText = nodeText;
            IsSelected = isSelected;
            ParentNodeId = parentNodeId; 
            ChildNodes = childNodes;
        }
        public TreeNode()
        {
            
        }



    }
}
