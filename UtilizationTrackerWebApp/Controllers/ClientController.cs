using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Models.DTO;
using UtilizationTrackerWebApp.Repository;
using UtilizationTrackerWebApp.Utility;
 

namespace UtilizationTrackerWebApp.Controllers
{
    public class ClientController : Controller
    {
        iClient_Repository MyRepository;
        public ClientController()
        {
            MyRepository = new Client_Repository();
        }

        // GET: Client
        [MyAuthorizationFilters(Role = "Admin,User,Manager")]
        public ActionResult Index()
        {

            List<Client_DTO> MyModelList = MyRepository.GetEntity_List();

            return View(MyModelList);
        }

        [MyAuthorizationFilters(Role ="Admin,User")]
        public ActionResult Create()
        {
            Client_Model MyModel = new Client_Model(); 

            return View(MyModel);
        }

        [HttpPost]
        public ActionResult Create(Client_Model MyModel )
        {

            if (MyRepository.ManageEntity(MyModel, "Post"))
                TempData["Notification"] =  Notification_Component.SetNotification((int)Notification_Component.Result.Success, "Client created successfully!");
            else
                TempData["Notification"] = Notification_Component.SetNotification((int)Notification_Component.Result.Info, "Client not created!");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {

            Client_Model MyModelList = MyRepository.GetEntity_List().Where(var => var.ID==id).Select(var=> new Client_Model() {ID= var.ID, vClientID=  var.vClientID, vDescription = var.vDescription, vName = var.vName }).FirstOrDefault();

            return View(MyModelList);
        }

        [HttpPost] 
        public ActionResult Edit(Client_Model MyModel)
        {
            if (MyRepository.ManageEntity(MyModel, "Put"))
                Notification_Component.SetNotification((int)Notification_Component.Result.Success, "Client updated successfully!");
            else
                Notification_Component.SetNotification((int)Notification_Component.Result.Info, "Client not updated!");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (MyRepository.ManageEntity(new Client_Model() {ID=id }, "Delete"))
                Notification_Component.SetNotification((int)Notification_Component.Result.Success, "Client deleted successfully!");
            else
                Notification_Component.SetNotification((int)Notification_Component.Result.Info, "Client not deleted!");

            return RedirectToAction("Index");
        }
    }
}