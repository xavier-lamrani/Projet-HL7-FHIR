using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Hl7.Fhir.Rest;
using Last_Fhir.Services;
using Last_Fhir.Models;

namespace Last_Fhir.Controllers
{
    public class HomeController : Controller
    {
        public IPatient metier { get; set; }

        public HomeController(IPatient metier)
        {
        this.metier = metier;
        }
        public IActionResult Index()
        {
         
            IEnumerable<Patient> prods = metier.findall();
            return View("Home", prods);
        }


        public IActionResult Create()
        {
        
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Name,BirthDate,Gender")] Patient p)
        {
            if (ModelState.IsValid)
            {
                // traitement
                metier.Save(p);
                return RedirectToAction(nameof(Index));
            }
         
            return View(p);
        }

        [HttpGet]
        public IActionResult Edit(string ID)
        {
            Patient p = metier.Getone(ID);               
            return View(p);
           
        }

        [HttpPost]
        public IActionResult Update(Patient p)
        {

            if (ModelState.IsValid)
            {
                Patient pa= metier.Getone(p.Id);
                pa.Name = p.Name;          
                pa.BirthDate = p.BirthDate;
                pa.Gender = p.Gender;
                metier.Update(pa);
                return RedirectToAction("Index");
            }
            else { return View("Edit"); }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
