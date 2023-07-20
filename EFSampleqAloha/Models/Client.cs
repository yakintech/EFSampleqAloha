using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleqAloha.Models
{
    public class Client : BaseModel
    {
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
