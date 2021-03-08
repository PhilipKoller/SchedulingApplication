using Microsoft.EntityFrameworkCore;
using SchedulingApplication.Models;

namespace SchedulingApplication.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Philip",
                    LastName = "Koller",
                    Email = "Venolium@gmail.com",
                    Password = "DHFJSDH34",
                    Phone = "972-523-4007",
                    Rank = Rank.Cpl,
                    Area = Area.SOI,

                }  
            );
            //-------------SEED Data for Calendar Events ---------
            //modelBuilder.Entity<Event>().HasData(
            //    new Event
            //    {
            //        ID = 1,
            //        EventType = EventType.PT,
            //        StartTime = System.DateTime.Now,
            //        EndTime = System.DateTime.Now,
            //        Color = "Purple",
            //        Location = Area.CampHorno,
            //        NumOfPeople = 95,
            //        PocRankName = "phil",
            //        PocPhoneNumber = "972-523-4343"
            //    }
            //    );

            //modelBuilder.Entity<Event>().HasData(
            //    new Event
            //    {
            //        ID = 2,

            //        Location = Area.CampHorno,
            //        NumOfPeople = 95,  
            //        Poc = "Miller 972-523-4343"
            //    }
            //    );

            //modelBuilder.Entity<Event>().HasData(
            //    new Event
            //    {
            //        ID = 3,
            //        Location = Area.CampHorno,
            //        NumOfPeople = 95,
            //        Poc = "Miller 972-523-4343"
            //    }
            //    );

            //modelBuilder.Entity<Event>().HasData(
            //    new Event
            //    {
            //        ID = 4,
            //        Location = Area.CampHorno,
            //        NumOfPeople = 95,
            //        Poc = "Miller 972-523-4343"
            //    }
            //    );

            //modelBuilder.Entity<Event>().HasData(
            //    new Event
            //    {
            //        ID = 5,
            //        Location = Area.CampHorno,
            //        NumOfPeople = 95,
            //        Poc = "Miller 972-523-4343"
            //    }
            //    );


        }
    }
}
