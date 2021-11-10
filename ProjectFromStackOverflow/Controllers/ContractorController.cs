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
        [Route("{id}")]
        public IActionResult ShowContractorGet(int id)
        {
            // код для извлечения объекта из БД
            var contractor = new Contractor();
            contractor.Id = id;
            contractor.Name = "Test";
            return View(contractor);
            
        }

        [HttpPost]
        public IActionResult ShowContractorPost(int id)
        {
            return RedirectToAction("ShowContractorGet", id);
        }
    }
}
