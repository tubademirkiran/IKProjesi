using IKProjesi.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesi.REP
{
    public class DbSingleTone
    {
        static IKContext db;
        static public IKContext GetInstance()
        {
            if (db == null)
            {
                db = new DL.IKContext();
            }
            return db;
        }
    }
}
