
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
            using (IDBConnection dbConnection = Connection)
            {
                dbConnection.Open();

                string sql = 'SELECT t1.PersonStatusID, t1.FirstName, t1.LastName FROM persondatabase.person t1 LEFT JOIN persondatabase.personstatus t2 ON t1.PersonStatusID = t2.PersonStatusID';
                return dbConnection.Query<status>(sql,commandType: commandText.ToList();
            }
        }
    }
}