using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;

namespace UtilizationTrackerWebApp.Models.Data
{
    public class Client_Model
    {
        public int ID { set; get; }

        [Required(ErrorMessage ="Client name is Required!")]
        public string vName { set; get; }

        [Required(ErrorMessage = "Client id name is Required!")]
        public string vClientID { set; get; }
        public string vDescription { set; get; }
        
    }
}