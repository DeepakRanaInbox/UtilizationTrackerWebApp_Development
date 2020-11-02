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
using UtilizationTrackerWebApp.Utility;

namespace UtilizationTrackerWebApp.Repository
{
    public class Client_Repository : iClient_Repository
    {
        public List<Client_DTO> GetEntity_List()
        {
            List<Client_DTO> MyModelList = new List<Client_DTO>();

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
                    MyDynamicParameters.Add("@vClientID", "0");

                    MyModelList = con.Query<Client_DTO>("ProcManageClient", MyDynamicParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception Exc)
            {
                Error_Component.ManageError(new Error_DTO {vAction_Type= "Repository", vController= "Client_Repository", vAction = "GetEntity_List", vError_Message= Exc.Message, vError_Line="",vInput_Values="",vRemarks="" });
            }

            return MyModelList;
        }
 
        public bool ManageEntity(Client_Model MyModel,string Action)
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
                    MyDynamicParameters.Add("@vClientID", MyModel.vClientID);

                    MyResult = con.Execute("ProcManageClient", MyDynamicParameters, commandType: CommandType.StoredProcedure)>0 ? true : false;
                }
            }
            catch (Exception Exc)
            {
                Error_Component.ManageError(new Error_DTO { vAction_Type = "Repository", vController = "Client_Repository", vAction = "GetEntity_List", vError_Message = Exc.Message, vError_Line = "", vInput_Values = "", vRemarks = "" });
            }

            return MyResult;
        }
    }
}