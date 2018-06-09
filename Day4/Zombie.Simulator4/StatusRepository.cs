
using System.Data;
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

                string sql = 'select p.FirstName,p.LastName. ps.StatusDescription from person person inner join personstatus pson p.personstatusid = ps.personstatusid';
                return dbConnection.Query<status>(sql,commandType: commandText).ToList();
            }
        }
    }
}