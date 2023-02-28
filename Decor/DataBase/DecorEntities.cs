using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor.DataBase
{
    public partial class DecorEntities
    {
        private static DecorEntities context;
        public static DecorEntities GetContext()
        {
            if (context == null)
                context = new DecorEntities();

            return context;
        }
    }
}
