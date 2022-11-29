using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public static class Extensions
    {
        public static bool IsIn(this object @object, params object[] objects)
            =>objects.Where(o => o == @object).Any();

    }
}
