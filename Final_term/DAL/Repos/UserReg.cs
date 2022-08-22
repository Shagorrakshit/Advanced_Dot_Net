using DAL.DB;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UserReg : IRepo<Login_Table, int, bool>
    {
        private dbl_demoEntities db;

        public UserReg(dbl_demoEntities db)
        {
            this.db = db;
        }
        public bool Create(Login_Table obj)
        {
            db.Login_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Login_Table> Get()
        {
            return db.Login_Table.ToList();
        }

        public Login_Table Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Login_Table obj)
        {
            throw new NotImplementedException();
        }
    }
}
