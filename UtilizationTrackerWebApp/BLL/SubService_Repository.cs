using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Models.DTO;
using UtilizationTrackerWebApp.Repository;
using UtilizationTrackerWebApp.Utility;


namespace UtilizationTrackerWebApp.BLL
{
    public class SubService_Repository : iSubService_Repository
    {
        public List<SubService_Model> GetEntity_List()
        {
            List<SubService_Model> MyModelList = new List<SubService_Model>();

            try
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {

                    DynamicParameters MyDynamicParameters = new DynamicParameters();

                    MyDynamicParameters.Add("@Action", "Get");
                    MyDynamicParameters.Add("@ID", "0");
                    MyDynamicParameters.Add("@ActionBy", "0");
                    MyDynamicParameters.Add("@vName", "0");
                    MyDynamicParameters.Add("@vDescription", "0");
                    MyDynamicParameters.Add("@iMasterServiceID", "0");

                    MyModelList = con.Query<SubService_Model>("ProcManageSub_Service", MyDynamicParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception Exc)
            {
                Error_Component.ManageError(new Error_DTO { vAction_Type = "Repository", vController = "MasterService_Repository", vAction = "GetEntity_List", vError_Message = Exc.Message, vError_Line = "", vInput_Values = "", vRemarks = "" });
            }

            return MyModelList;
        }

        public bool ManageEntity(SubService_Model MyModel, string Action)
        {
            bool MyResult = false;

            try
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {

                    DynamicParameters MyDynamicParameters = new DynamicParameters();
                    MyDynamicParameters.Add("@Action", Action);
                    MyDynamicParameters.Add("@ID", MyModel.ID);
                    MyDynamicParameters.Add("@ActionBy", SessionComponent.UID);
                    MyDynamicParameters.Add("@vName", MyModel.vName);
                    MyDynamicParameters.Add("@vDescription", MyModel.vDescription);
                    MyDynamicParameters.Add("@iMasterServiceID", MyModel.iMasterServiceID);

                    MyResult = con.Execute("ProcManageSub_Service", MyDynamicParameters, commandType: CommandType.StoredProcedure) > 0 ? true : false;
                }
            }
            catch (Exception Exc)
            {
                Error_Component.ManageError(new Error_DTO { vAction_Type = "Repository", vController = "SubService_Repository", vAction = "ManageEntity", vError_Message = Exc.Message, vError_Line = "", vInput_Values = "", vRemarks = "" });
            }

            return MyResult;
        }

    
    }
}