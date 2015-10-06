using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.DAL.Entities
{
    public class Locations
    {
        public int LocationID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false), StringLength(50)]
        public string Street { get; set; }
        [Required(AllowEmptyStrings = false), StringLength(50)]
        public string City { get; set; }
        [Required(AllowEmptyStrings = false), StringLength(30)]
        public string Province { get; set; }
        [Required(AllowEmptyStrings = false), StringLength(2, MinimumLength = 2)]
        public string Contact { get; set; }
        public string Phone { get; set; }
    }
}
