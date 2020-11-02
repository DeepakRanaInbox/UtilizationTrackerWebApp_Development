using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Models.DTO;
namespace UtilizationTrackerWebApp.Repository
{
    public interface iSubService_Repository
    {
        List<SubService_Model> GetEntity_List();
        bool ManageEntity(SubService_Model MyModel, string Action);
    }
}