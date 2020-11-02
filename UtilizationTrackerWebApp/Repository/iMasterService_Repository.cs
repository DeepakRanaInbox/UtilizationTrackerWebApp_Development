using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Models.DTO;
namespace UtilizationTrackerWebApp.Repository
{
    public interface iMasterService_Repository
    {
        List<MasterService_Model> GetEntity_List();
        bool ManageEntity(MasterService_Model MyModel, string Action);
    }
}