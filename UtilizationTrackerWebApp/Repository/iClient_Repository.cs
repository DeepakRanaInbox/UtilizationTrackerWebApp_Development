using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Models.DTO;

namespace UtilizationTrackerWebApp.Repository
{
    public interface iClient_Repository
    {
         List<Client_DTO> GetEntity_List();
         bool ManageEntity(Client_Model MyModel,string Action);
    }
}