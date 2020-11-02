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
    public class SubService_Model
    {
        public int ID { set; get; }

        [Required(ErrorMessage = "Name is Required!")]
        public string vName { set; get; }

        [Required(ErrorMessage = "Master Service is Required!")]
        public string iMasterServiceID { set; get; }

        public List<SelectListItem> MasterServiceList { set; get; }
        public string MasterService { set; get; }
        public string vDescription { set; get; }
    }
}