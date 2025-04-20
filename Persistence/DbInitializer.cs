using Domain;

namespace Persistence
{
    public class DbInitializer
    {
        public static async Task SeedData(AppDbContext context)
        {
            if(context.Activities.Any()) return; // DB has been seeded

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Latitude = 18.517662,
                    Longitude = 73.837254
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "London",
                    Venue = "Museum",
                    Latitude = 43.5417662,
                    Longitude = -40.84437254
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                    Latitude = 48.51764562,
                    Longitude = -3.8372543534
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "culture",
                    City = "London",
                    Venue = "British Museum",
                    Latitude = 21.5170662,
                    Longitude = 30.999837254
                },
            };

            context.Activities.AddRange(activities);

            await context.SaveChangesAsync();
        }
    }
}
