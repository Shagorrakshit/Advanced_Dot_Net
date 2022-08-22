using DAL.DB;
using DAL.interfaces;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class dataAccessFactory
    {
        static dbl_demoEntities db = new dbl_demoEntities();
        public static IRepo<Login_Table, int, bool> GetUserDataAccess()
        {
            return new UserReg(db);
        }
        public static IRepo<Token, string, Token> GetTokenAccess()
        {
            return new TokenRepo(db);
        }
        public static IRepo<Login_Table, string, bool> GetUserDatAccess()
        {
            return new User(db);
        }
        public static IAuth<Login_Table> GetAuthDataAccess()
        {
            return new User(db);
        }
    }
}
