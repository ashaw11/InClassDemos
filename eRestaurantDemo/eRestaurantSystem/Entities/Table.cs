using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestaurantSystem.Entities
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }
        [Required, Range(1,25)]
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        //Navigation Property
        //see Reservation for notes (except switch wherever it says reservations and tables)
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Table()
        {
            Available = true;
        }
    }
}
