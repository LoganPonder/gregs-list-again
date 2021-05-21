using System;
using System.Collections.Generic;
using gregs_list_again.DB;
using gregs_list_again.Models;

namespace gregs_list_again.Services
{
    public class JobsService
    {
        internal IEnumerable<Job> GetAllJobs()
        {
            return FakeDB.Jobs;
        }

        internal Job GetJobById(string id)
        {
            Job found = FakeDB.Jobs.Find(j => j.Id == id);
            if(found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Job CreateJob(Job newJob)
        {
            FakeDB.Jobs.Add(newJob);
            return newJob;
        }

        internal Job EditJob(Job editJob)
        {
            Job oldJob = GetJobById(editJob.Id);
            oldJob.JobTitle = editJob.JobTitle;
            oldJob.Company = editJob.Company;
            oldJob.Salary = editJob.Salary;
            oldJob.Description = oldJob.Description;
            return oldJob;
        }

        internal void DeleteJob(string id)
        {
            Job found = GetJobById(id);
            FakeDB.Jobs.Remove(found);
        }
    }
}