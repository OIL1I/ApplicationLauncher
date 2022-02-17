using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLauncher.Controls
{
    public class ItemFlowLayoutPanel : System.Windows.Forms.FlowLayoutPanel
    {
        public int SelectionIndex;

        public event EventHandler<ItemFlowLayoutPanelEventArgs> SelectionChanged;

        public virtual void OnSelectionChanged(ItemFlowLayoutPanelEventArgs e)
        {
            EventHandler<ItemFlowLayoutPanelEventArgs> handler = SelectionChanged;

            if (handler != null) handler(this, e);
        }
    }
}
