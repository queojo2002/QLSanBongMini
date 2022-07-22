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
        public DataTable Select_By_ID(int ID)
        {
            return DAL_FWA.Instance.Select_By_ID(ID);
        }
        public bool Insert(int IDLoaiFWA, string TenFWA, int GiaTien, string img)
        {
            return DAL_FWA.Instance.Insert(IDLoaiFWA, TenFWA, GiaTien, img);
        }
        public DataTable Select_By_IDLoaiFWA(int ID)
        {
            return DAL_FWA.Instance.Select_By_IDLoaiFWA(ID);
        }
        public bool Update(int IDFWA, int IDLoaiFWA, string TenFWA, int GiaTien, string img)
        {
            return DAL_FWA.Instance.Update(IDFWA, IDLoaiFWA, TenFWA, GiaTien, img);
        }
        public bool Update(int IDFWA, int IDLoaiFWA, string TenFWA, int GiaTien)
        {
            return DAL_FWA.Instance.Update(IDFWA, IDLoaiFWA, TenFWA, GiaTien);
        }
    }
}
