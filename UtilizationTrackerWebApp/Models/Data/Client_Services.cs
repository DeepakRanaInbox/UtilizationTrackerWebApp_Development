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
    public class Client_Services
    {
        [Required(ErrorMessage = "Client is Required!")]
        public string iClientID { set; get; }
        public List<SelectListItem> ClientList { set; get; }
        public List<SelectListItem> MasterServiceList { set; get; }
        public List<SelectListItem> SubServiceList { set; get; }
        public string iMasterServiceID { set; get; }
        public string iSubServiceID { set; get; }
  
    }
}