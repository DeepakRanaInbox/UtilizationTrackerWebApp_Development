using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Models.DTO;

namespace UtilizationTrackerWebApp.Repository
{
    interface iAccount_Repository
    {
        List<Login_DTO> AuthenticationUser(Login_Model MyModel);
    
    }
}
