using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_DB
    {
        private static BUS_DB instance;

        public static BUS_DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_DB();
                }
                return instance;
            }
            private set
            {
                BUS_DB.instance = value;
            }
        }


        private BUS_DB() { }


        public bool Check_Connect()
        {
            return DAL_DB.Instance.Check_Connect();
        }
    }
}
