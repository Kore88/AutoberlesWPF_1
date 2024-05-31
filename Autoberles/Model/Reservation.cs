using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoberles.Model
{
    internal class Reservation
    {
        int resID;
        int carID;
        int userID;
        DateOnly startDate;
        DateOnly endDate;
        bool state;

        public int ResID { get => resID; set => resID = value; }
        public int CarID { get => carID; set => carID = value; }
        public int UserID { get => userID; set => userID = value; }
        public DateOnly StartDate { get => startDate; set => startDate = value; }
        public DateOnly EndDate { get => endDate; set => endDate = value; }
        public bool State { get => state; set => state = value; }
    }
}
