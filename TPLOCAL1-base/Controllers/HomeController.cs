using Microsoft.AspNetCore.Mvc;
using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be named with "Controller" at the end !!!
namespace TPLOCAL1.Controllers;

public class HomeController : Controller
{
    //methode "naturally" called by router
    public ActionResult Index(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            //retourn to the Index view (see routing in Program.cs)
            return View();
        else
        {
            //Call different pages, according to the id pass as parameter
            return id switch
            {
                "OpinionList" => View(id),
                "Form" => View(id),
                _ => View(),
            };
        }
    }

    //method to send datas from form to validation page
    [HttpPost]
    public ActionResult ValidationFormulaire(FormModel model)
    {
        if (model.Gender == "select") ModelState.AddModelError("Gender", "You must select a Gender");
        if (model.TrainingType == "select2") ModelState.AddModelError("TrainingType", "You must select a Course");

        if (ModelState.IsValid)
        {
            return View("~/Views/Shared/ValidationPage.cshtml", model);
        }

        return View("~/Views/Shared/Form.cshtml");
    }
}