using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiška_užd
{
    internal class Player
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public double height { get; set; }
        public string position { get; set; }
        public string club { get; set; }
        public bool invited { get; set; }
        public bool captain { get; set; }

        public Player(string firstName, string lastName, DateTime birthDate, double height, string position, string club, bool invited, bool captain)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.height = height;
            this.position = position;
            this.club = club;
            this.invited = invited;
            this.captain = captain;
            }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.birthDate.Year;
            if (this.birthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

    }
}
