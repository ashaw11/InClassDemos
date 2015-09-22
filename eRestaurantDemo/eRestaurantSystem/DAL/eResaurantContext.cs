using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.Entities;
using System.Data.Entity;
#endregion

namespace eRestaurantSystem.DAL
{
    //this class should be restricted to access by ONLY the BLL methods. This class should not be accessable outside the component library
    internal class eResaurantContext : DbContext
    {
        public eResaurantContext() : base ("name=EatIn")
        {
            //constructor is used to pass webs config 
        }
        //setup the DBSet. One per entity I create.
        public DbSet<SpecialEvent> SpecialEvents {get; set;}
        public DbSet<Reservation > Reservations {get; set;}
        public DbSet<Table> Tables {get; set;}
    }
    
    //when overriding OnModelCreating(), it is important to remember to call the base methods implementation before you exit the method.

    //The ManyToManyNavigationPropertyConfiguration.Map method lets you configure the tables and columns used for many-to-many relationships. It takes a ManyToManyNavigationPropertyConfigurationinstance in which you specify the column names b calling the MapLeftKey, MapRightKey, and ToTable methods.

    //the "left" key is the one specified in the MasMany method. The "right" key is the one specified in the WithMany method.

    //we have a many to many relationship between reservation and tables. A reservation may need many tables. A table can have overcome many reservations.

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Reservation>().HasMany(r => r.Tables)
            .WithMany(x => x.Reservations)
            .Map(mapping =>
            {
                mapping.ToTable("ReservationTables");
                mapping.MapLeftKey("TableID");
                mapping.MapRightKey("ReservationID");
            });
        base.OnModelCreating ()
    }
}