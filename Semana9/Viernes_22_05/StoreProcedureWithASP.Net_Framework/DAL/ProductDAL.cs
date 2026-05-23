using System.Configuration;

namespace StoreProcedureWithASP.Net_Framework.DAL
{
    public class ProductDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();


    }
}