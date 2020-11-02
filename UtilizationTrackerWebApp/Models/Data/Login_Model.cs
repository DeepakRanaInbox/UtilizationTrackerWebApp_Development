using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UtilizationTrackerWebApp.Models.Data
{
    public class Login_Model
    {
        public int ID { set; get; }

        [Required(ErrorMessage = "User name is required!")]
        public string vLoginID { set; get; }

        [Required(ErrorMessage = "Password is required!")]
        public string vPassword { set; get; }
    }


}