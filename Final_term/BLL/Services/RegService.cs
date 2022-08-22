using BLL.Bos;
using DAL;
using DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
  public  class RegService
    {
        public static List<Reg> Get()
        {
            var data = dataAccessFactory.GetUserDataAccess().Get();
            var rdata = new List<Reg>();
            foreach (var item in data)
            {
                rdata.Add(new Reg()
                {
                    ID = item.ID,
                    Username = item.Username,
                    Password = item.Password,
                    Type = item.Type
                  
                });
            }
            return rdata;
        }
        public static bool Create(Reg item)
        {
            var student = new Login_Table()
            {
                ID = item.ID,
                Username = item.Username,
                Password = item.Password,
                Type = item.Type

            };
            return dataAccessFactory.GetUserDataAccess().Create(student);
        }
    }
}
