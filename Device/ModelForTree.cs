using Aga.Controls.Tree;
using System.Collections;

namespace Simargl.Device
{
    internal class ModelForTree : TreeModelBase
    {
        public ModelForTree(Dictionary<string, Crevis> Devices)
        {
            devices = Devices;
        }
        private Dictionary<string, Crevis> devices;

        public override IEnumerable GetChildren(TreePath treePath)
        {
            var ArrayList = new ArrayList();
            if (treePath.IsEmpty())
            {
                foreach (var device in devices)
                {
                    ArrayList.Add(device.Value);
                }
            }
            else if (treePath.LastNode is Crevis)
            {
                Crevis crevis = (Crevis)treePath.LastNode;
                ArrayList.AddRange(crevis.Areas);
            }
            else if (treePath.LastNode is Area)
            {
                Area area = (Area)treePath.LastNode;
                ArrayList.Add(area.Watering);
            }
            else if (treePath.LastNode is Watering)
            {
                Watering watering = (Watering)treePath.LastNode;
                ArrayList.Add(watering.Pump);
                ArrayList.Add(watering.Gate);
            }
            return ArrayList;
        }

        public override bool IsLeaf(TreePath treePath)
        {
            if (treePath.LastNode is Crevis || treePath.LastNode is Area || treePath.LastNode is Watering)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void NotifyStructureChanged(TreePath treePath)
        {
            OnStructureChanged(new TreePathEventArgs(treePath));
        }
    }
}
