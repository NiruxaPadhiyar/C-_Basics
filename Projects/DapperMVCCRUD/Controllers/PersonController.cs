using Dapper;
using DapperMVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperMVCCRUD.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<PersonModel>("PersonViewAll",null));
        }
        [HttpGet]
        public ActionResult ADdOrEdit(int id=0)


        {
            if(id==0)
            {
                return View();

            }
          
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PersonID", id);
                return View(DapperORM.ReturnList<PersonModel>("PersonViewByID", param).FirstOrDefault<PersonModel>());
                
            }

               

        }

        [HttpPost]
        public ActionResult AddOrEdit(PersonModel person)


        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PersonID", person.PersonID);
            param.Add("@FirstName", person.FirstName);
            param.Add("@LastName", person.LastName);
            param.Add("@Age", person.Age);
            param.Add("@EmailID", person.EmailID);
            param.Add("@Gender", person.Gender);
            param.Add("@AddressID", person.AddressID);

            DapperORM.ExecuteWithoutReturn("PersonAddOrEdit", param);

            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PersonID", id);
            DapperORM.ExecuteWithoutReturn("PersonDeleteByID", param);
            return RedirectToAction("Index");

        }
    }
}