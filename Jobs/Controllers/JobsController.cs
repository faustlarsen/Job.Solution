using Microsoft.AspNetCore.Mvc;
using JobOffer.Models;
using System.Collections.Generic;

namespace JobOffer.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string jobtitle, string description, string name, string phone)
    {
      Job myJob = new Job(jobtitle, description, name, phone);
      return RedirectToAction("Index");
    }
  }
}
