using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_FWA
    {
        private static BUS_FWA instance;

        public static BUS_FWA Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_FWA();
                }
                return instance;
            }
            private set
            {
                BUS_FWA.instance = value;
            }
        }

        private BUS_FWA() { }

        public DataTable Select()
        {
            return DAL_FWA.Instance.Select();
        }
        public bool Insert(int IDLoaiFWA, string TenFWA, int GiaTien, string img)
        {
            return DAL_FWA.Instance.Insert(IDLoaiFWA, TenFWA, GiaTien, img);
        }

    }
}
