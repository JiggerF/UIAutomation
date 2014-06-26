using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroUITests.Page
{
    public class Accounts
    {
        private static SalesPage _sp = new SalesPage();

        public static SalesPage SalesPage
        {
            get
            {
                return _sp;
            }
        }
    }
}
