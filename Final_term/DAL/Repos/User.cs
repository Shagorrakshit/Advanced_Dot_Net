using DAL.DB;
using DAL.interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class User : IRepo<Login_Table, string, bool>, IAuth<Login_Table>
    {
        dbl_demoEntities db;
        public User(dbl_demoEntities db)
        {
            this.db = db;
        }
        public Login_Table Authenticate(string username, string password)
        {
            return db.Login_Table.FirstOrDefault(u => u.Username.Equals(username)
                        && u.Password.Equals(password));
        }

        public bool Create(Login_Table obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Login_Table> Get()
        {
            throw new NotImplementedException();
        }

        public Login_Table Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Login_Table obj)
        {
            throw new NotImplementedException();
        }
    }
}
