using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bos
{
   public class TokenModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TokenKey { get; set; }
        public System.DateTime DateTime { get; set; }
        public Nullable<System.DateTime> ExpiredAt { get; set; }
    }
}
