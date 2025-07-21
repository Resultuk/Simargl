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
                ArrayList.Add(area.Lighting);
                ArrayList.Add(area.Sensors);
            }
            else if (treePath.LastNode is Watering)
            {
                Watering watering = (Watering)treePath.LastNode;
                ArrayList.Add(watering.Pump);
                ArrayList.Add(watering.Gate);
            }
            else if (treePath.LastNode is Lighting)
            {
                Lighting lighting = (Lighting)treePath.LastNode;
                ArrayList.Add(lighting.CH1);
                ArrayList.Add(lighting.CH2);
                ArrayList.Add(lighting.CH3);
                ArrayList.Add(lighting.CH4);
            }
            else if (treePath.LastNode is Sensors)
            {
                ArrayList.AddRange(((Sensors)treePath.LastNode).List.OrderBy(x => x.Key).Select(x => x.Value).ToArray());
            }
            else if (treePath.LastNode is Sensor)
            {
                ArrayList.AddRange(((Sensor)treePath.LastNode).Params.Values);
            }
            return ArrayList;
        }

        public override bool IsLeaf(TreePath treePath)
        {
            if (treePath.LastNode is Param || treePath.LastNode is Pump || treePath.LastNode is Gate || treePath.LastNode is Channel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void NotifyStructureChanged(TreePath treePath)
        {
            OnStructureChanged(new TreePathEventArgs(treePath));
        }
    }
}
