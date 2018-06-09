using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace Zombie.Simulator4
{
public class StatusRepository: Repository
    {   
        //create a method
        public List<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                /*string sql = "SELECT p.FirstName, p.LastName, ps.StatusDescription" + "FROM persondatabase.person p" + "INNER JOIN persondatabase.personstatus ps"+ "ON p.PersonStatusID = ps.PersonStatusID";*/

                string sql = "SELECT p.FirstName, p.LastName, ps.StatusDescription FROM persondatabase.person p INNER JOIN persondatabase.personstatus ps ON p.PersonStatusID = ps.PersonStatusID"; //works

                return dbConnection.Query<Status>(sql,commandType:CommandType.Text).ToList();
            }
        }
    }
}