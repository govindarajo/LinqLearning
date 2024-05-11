using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPreparation
{
    public static class ExtensionClass
    {
        public static string ChangeTheFirstCase(this string name)
        {
            var charArray = name.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray);
        }
    }
}
