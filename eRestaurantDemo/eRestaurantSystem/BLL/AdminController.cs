using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel; //use for ODS access
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class AdminController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            using (var context = new eResaurantContext())
            {
                //retrieve the data from the SpecialEvents table on sql. To do so, we will use the DbSet in eRestaurantContext called SpecialEvents (done by mapping)

                //method syntax
                return context.SpecialEvents.OrderBy(x => x.Description).ToList();
            }
        }
    }
}
