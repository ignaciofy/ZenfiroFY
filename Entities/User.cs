using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public CodePhone CodePhoneLocal { get; set; }
        public int Id_CodPhoneLocal { get; set; }
        public int PhoneLocal { get; set; }
        public CodePhone CodePhoneCel { get; set; }
        public int Id_CodPhoneCel { get; set; }
        public int PhoneCel { get; set; }
        public DateTime dtBirthday { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int Id_Gender { get; set; }
        public Country Country { get; set; }
        public int Id_Country { get; set; }
        public int Id_Province { get; set; }
        public int Id_Location { get; set; }
        public string Address { get; set; }
        public Rol Rol { get; set; }
        public int Id_Rol { get; set; }
        public Cargo Cargo { get; set; }
        public int Id_Cargo { get; set; }
        public Area Area { get; set; }
        public int Id_Area { get; set; }
        public short IsContractor { get; set; }
        public DateTime dtCreacion { get; set; }
        public DateTime dtModificacion { get; set; }
        public short Active { get; set; }
    }
}
