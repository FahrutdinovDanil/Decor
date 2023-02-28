using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor.DataBase
{
    public class DataAccess
    {
        public delegate void RefreshListDelegate();
        public static event RefreshListDelegate RefreshList;
        public static List<Product> GetProducts()
        {
            return DecorEntities.GetContext().Products.ToList();
        }
    }
}
