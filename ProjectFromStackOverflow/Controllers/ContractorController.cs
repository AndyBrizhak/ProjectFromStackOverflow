using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectFromStackOverflow.Models;

namespace ProjectFromStackOverflow.Controllers
{
    public class ContractorController : Controller
    {
        [HttpGet]
        public IActionResult ShowContractorGet(Contractor _contractor)
        {
            // код для извлечения объекта из БД
            var contractor = new Contractor();
            contractor.Id = _contractor.Id;
            contractor.Name = "Test";
            return View(contractor);
            
        }

        [HttpPost]
        public IActionResult ShowContractorPost(Contractor _contractor)
        {

           return RedirectToAction("ShowContractorGet", _contractor);
        }
    }
}
