using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace SaveHelper
{
    [Serializable]
    public class SaveItem : DynamicObject
    {
        Dictionary<string, object> dic = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result) => dic.TryGetValue(binder.Name, out result);

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            dic[binder.Name] = value;
            return true;
        }

        public Dictionary<string, object> GetDictionary() => dic;
    }
}
