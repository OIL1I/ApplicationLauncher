using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLauncher.Controls
{
    public class LauncherItemFlowLayoutPanel : System.Windows.Forms.FlowLayoutPanel
    {
        public int SelectionIndex;

        public event EventHandler<LauncherItemFlowLayoutPanelEventArgs> SelectionChanged;

        public virtual void OnSelectionChanged(LauncherItemFlowLayoutPanelEventArgs e)
        {
            EventHandler<LauncherItemFlowLayoutPanelEventArgs> handler = SelectionChanged;

            if (handler != null) handler(this, e);
        }
    }
}
