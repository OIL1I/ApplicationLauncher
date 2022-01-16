using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHelper
{
    public interface ISaveable
    {
        SaveItem GetSaveItem();

        void ConvertFromSaveItem(SaveItem item);
    }
}
