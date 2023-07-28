using InternshipProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InternshipProject.Controllers
{
   
    public class HospitalData : Controller
    {
        private InternshipProjectDBContext _internshipProjectDBContext;

        public HospitalData(InternshipProjectDBContext internshipProjectDBContext)
        {
            _internshipProjectDBContext = internshipProjectDBContext;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet]
        [Authorize(Roles = "Admin,HR,sales")]
        public IActionResult DataTable()
        {
            IEnumerable<Hospital> hos = _internshipProjectDBContext.Hospitalss;
            return View(hos);
        }


        [HttpGet]
        [Authorize(Roles = "Admin,HR")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,HR")]
        public IActionResult Create(Hospital hos)
        {
            if (ModelState.IsValid)
            {
                _internshipProjectDBContext.Hospitalss.Add(hos);
                _internshipProjectDBContext.SaveChanges();
                return RedirectToAction("DataTable");
            }
                return View(hos);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,HR")]
        public IActionResult Edit(int? id)
        {
            if(id== null || id == 0)
            {
                return NotFound();

            }
            var hos=_internshipProjectDBContext.Hospitalss.Find(id);
            if (hos == null)
            {
                return NotFound();
            }
            return View(hos);
              
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,HR")]
        public IActionResult Edit(Hospital hos)
        {

            //if (hos == null)
            //{
            //    return NotFound();
            //}

            //var data = hos;
            //if (data != hos)
            //{
            //    return NotFound();
            //}
            if (ModelState.IsValid)
            {
                _internshipProjectDBContext.Hospitalss.Update(hos);
                _internshipProjectDBContext.SaveChanges();
                return RedirectToAction("DataTable");
            }

                return RedirectToAction("DataTable");

        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            var hos = _internshipProjectDBContext.Hospitalss.Find(id);
            if (hos == null)
            {
                return NotFound();
            }
            return View(hos);


        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteData(int? id)
        {
            var hos = _internshipProjectDBContext.Hospitalss.Find(id);
            if (hos == null)
            {
                return NotFound();
            }
            _internshipProjectDBContext.Hospitalss.Remove(hos);

            _internshipProjectDBContext.SaveChanges();

            return RedirectToAction("DataTable");
        }
    }
}
