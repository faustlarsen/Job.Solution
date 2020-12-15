using System;
using System.Collections.Generic;

namespace JobOffer.Models
{
  public class Job
  {
    public string JobTitle { get; set; }
    public string Description { get; set; }
    public string Name  { get; set; }
    public string Phone  { get; set; }
    
    private static List<Job> _instances = new List<Job>{};

    public Job(string jobtitle, string description, string name, string phone)
    {
      JobTitle = jobtitle;
      Description = description;
      Name = name;
      Phone = phone;
      _instances.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }
  }
}