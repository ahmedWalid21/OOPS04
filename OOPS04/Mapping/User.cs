using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS04.Mapping
{
    internal class User
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string PhoneNumber {  get; set; }
        public string cardNumber {  get; set; }
        public DateOnly ExpireDate { get; set; }
    }
}
