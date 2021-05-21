using System;
using System.ComponentModel.DataAnnotations;

namespace gregs_list_again.Models
{
    public class Job
    {
        public string Id { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public int Salary { get; set; }

        public string Description { get; set; }

        public Job(string jobTitle, string company, int salary, string description)
        {
            Id = Guid.NewGuid().ToString();
            JobTitle = jobTitle;
            Company = company;
            Salary = salary;
            Description = description;
        }
    }
}