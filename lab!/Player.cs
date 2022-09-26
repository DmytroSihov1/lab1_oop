using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_
{
    public class Player
    {
        public Player(string fullName, string role, Country country)
        {
            FullName = fullName;
            Role = role;
            Country = country;
        }

        public string FullName { get; set; }
        public string Role { get; set; }
        public Country Country { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", FullName, Role, Country.Name);
        }
    }
}
