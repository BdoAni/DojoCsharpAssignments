using System;
using System.Collections.Generic;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CRUDelicious.Controllers
{
    public class DishController: Controller
    {
        private CRUDEliciousContext db; //we paset same name as a our Context name 
        public DishController(CRUDEliciousContext context)
        {
            db = context;
        }
        [HttpGet]
        [Route("new")]
        public IActionResult New()// to create a new Dish
        {
            return View("New");
        }
        // /////////////////////////////**********************Create********************************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost("/new/create")]
        public IActionResult Create(Dish  newDish)
        {
            if (ModelState.IsValid == false)
            {
                return View("New");

            }
            db.Dishes.Add(newDish);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // /////////////////////////*****************Ditail  page rout****************************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        [HttpGet]
        [Route("{dishId}")]
        public IActionResult Details(int dishId)
        {
            Dish dish =db.Dishes.FirstOrDefault(d=>d.DishId == dishId);
            if( dish ==null)
            {
                return RedirectToAction("Index");
            }
            return View("Ditails", dish);
        }
        // ///////////////////////////////*************Delete*******************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost("/{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if (dish != null)
            {
                return RedirectToAction("Index");
            }
            db.Dishes.Remove(dish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // //////////////////////////////////////////************* Edit******************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpGet("/{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if (dish == null)
            {

                return RedirectToAction("Index");
            }
                return View("Edit", dish);
        }
        //////////////////////////****************************Update*************************************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost("/{dishId}/update")]
        public IActionResult Update( Dish editedDish, int dishId)
        {
            if (ModelState.IsValid == false)
            {
                return View("Edit");
            }
            Dish dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            dish.Name=editedDish.Name;
            dish.Chef = editedDish.Chef;
            dish.Tastiness = editedDish.Tastiness;
            dish.Calories = editedDish.Calories;
            dish.Description = editedDish.Description;
            db.Dishes.Update(dish);
            db.SaveChanges();
            // return Redirect($"/dishes/{dishId}");
            return RedirectToAction("Ditails", new{dishId = dishId });
        }
    }
}
// dotnet ef migrations add FirstMigration