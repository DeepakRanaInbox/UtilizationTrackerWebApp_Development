using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UtilizationTrackerWebApp.Utility
{
    public class Global_Component
    {

        public static List<SelectListItem> FillDropdownList(List<SelectListItem> MyList, string FirstValue)
        {

            MyList = MyList.OrderBy(var => var.Value).OrderBy(var => var.Text).ToList();

            SelectListItem MyFirstItem = new SelectListItem { Value = "", Text = FirstValue };
            MyList.Insert(0, MyFirstItem);
            return MyList;
        }

        public static string GenerateFileName(string filename)
        {

            string sFile = "~/Blob_Storage/User_Images/" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 18) + filename;

            return sFile;
        }
    }

   
}