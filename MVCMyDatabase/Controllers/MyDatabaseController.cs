﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCMyDatabase.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCMyDatabase.Controllers
{
    public class MyDatabaseController : Controller
    {
        MyDatabaseDataAccessLayer objemployee = new MyDatabaseDataAccessLayer();
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] MyDatabase employee)
        {
            if (ModelState.IsValid)
            {
                objemployee.InsertEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Index()
        {
            List<MyDatabase> listEmployee = new List<MyDatabase>();
            listEmployee = objemployee.GetAllEmployees().ToList();

            return View(listEmployee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyDatabase employee = objemployee.getEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]MyDatabase employee)
        {
            if (id != employee.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objemployee.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyDatabase employee = objemployee.getEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MyDatabase employee = objemployee.getEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objemployee.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}

//public class EmployeeController : Controller
//{
//    EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

//    // GET: /<controller>/
//    public IActionResult Index()
//    {
//        return View();
//    }
//}

