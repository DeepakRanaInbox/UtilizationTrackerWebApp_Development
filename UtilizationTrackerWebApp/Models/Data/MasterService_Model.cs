using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;
using System.Web.Mvc;

namespace UtilizationTrackerWebApp.Models.Data
{
    public class MasterService_Model
    {
        public int ID { set; get; }

        [Required(ErrorMessage = "Name is Required!")]
        public string vName { set; get; }

        [Required(ErrorMessage = "Client is Required!")]
        public string iClientID { set; get; }
        public List<SelectListItem> ClientList { set; get; }

        public string Client { set; get; }
        public string vDescription { set; get; }

    }
}