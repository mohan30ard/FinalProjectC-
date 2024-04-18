using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace phase_1
{
    //create connection string for azure db
    //Server=tcp:ironbank32.database.windows.net,1433;Initial Catalog=BankDB;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication="Active Directory Default";

    //connect to above db
    //SqlConnection conn = new SqlConnection("Server=tcp:ironbank32.database.windows.net,1433;Initial Catalog=BankDB;Persist Security Info=False;User ID=ironbank32;Password=Ironbank123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

     //Scaffold-DbContext "Server=tcp:ironbank32.database.windows.net,1433;Initial Catalog=BankDB;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication='Active Directory Default';"  Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -DataAnnotations -Context BankDBContext 
     //

    public class DbClass
    {
        

        

    }
}
