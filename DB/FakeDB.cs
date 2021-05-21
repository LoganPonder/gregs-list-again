using System.Collections.Generic;
using gregs_list_again.Models;

namespace gregs_list_again.DB
{
    //  REVIEW why do I need to make this static, what happens if ommited, significance of namespace
    public static class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>() {
            new Car("https://www.rpm-autopassion.ca/rpm/wp-content/uploads/2019/01/ss69-1.jpg", "Chevelle SS", 1969, 120000)
        };

        public static List<Job> Jobs { get; set; } = new List<Job>() {
            new Job("Instructor", "Codeworks", 60000, "A great place to work")
        };
    }
}