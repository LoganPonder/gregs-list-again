using System;
using System.ComponentModel.DataAnnotations;

namespace gregs_list_again.Models
{
    public class Car
    {
        public string Id { get; set; }

        public string ImgUrl {get; set;} = "https://via.placeholder.com/150";
        
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Price { get; set; }


        // REVIEW why are some of the parameters lowercased/capital
        public Car(string imgUrl, string title, int year, int price)
        {
            Id = Guid.NewGuid().ToString();
            ImgUrl = imgUrl;
            Title = title;
            Year = year;
            Price = price;
        }
    }
}