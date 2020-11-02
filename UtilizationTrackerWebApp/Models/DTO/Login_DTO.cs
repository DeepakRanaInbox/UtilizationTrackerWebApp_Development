using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilizationTrackerWebApp.Models.DTO
{
    public class Login_DTO
    {
 
        public int ID { set; get; }
        public string vName { set; get; }
        public string vRole { set; get; }
        public string iRoleID { set; get; }   
        public string vLoginID { set; get; }
        public string vRegion { set; get; }
        public string vTimeZone { set; get; }
        public string iManager_Level1 { set; get; }
        public string iManager_Level2 { set; get; }
    }
}