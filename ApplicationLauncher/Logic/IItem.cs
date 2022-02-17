using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLauncher.Logic
{
    public interface IItem
    {
        bool IsSelected { get; set; }

        void SetClick(EventHandler handler);
        void RemoveClick(EventHandler handler);
        void SelectItem();
        void UnselectItem();
    }
}
