using Aga.Controls.Tree;
using Growor.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroworDesktop.Classes
{
    public static class TreeViewExtensions
    {
        public static List<string> GetExpandedNodesState(this TreeViewAdv tree)
        {
            var result = new List<string>();
            foreach (var node in tree.AllNodes)
            {
                if (node.IsExpanded)
                    result.Add(((IGuidable)node.Tag).GetGuid().ToString());
            }
            return result;
        }
        public static void RestoreExpandedNodesState(this TreeViewAdv tree, List<string> guids)
        {
            tree.BeginUpdate();

            foreach (var guid in guids)
            {
                foreach (var node in tree.AllNodes)
                {
                    if (((IGuidable)node.Tag).GetGuid().ToString().Equals(guid)) node.Expand();
                }
            }
            tree.Focus();
            tree.EndUpdate();
        }
    }
}
