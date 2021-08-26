using System.Collections.Generic;
using System.Dynamic;

namespace LearnDynamic
{
    public class PersonObject : DynamicObject
    {
        private Dictionary<string, object> members = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            members[binder.Name] = value;
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;
            if (members.ContainsKey(binder.Name))
            {
                result = members[binder.Name];
                return true;
            }

            return false;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            dynamic method = members[binder.Name];
            result = method((int) args[0]);
            return result != null;
        }
        
    }
}
