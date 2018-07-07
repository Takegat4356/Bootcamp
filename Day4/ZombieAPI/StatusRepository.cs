using System.Data;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace ZombieAPI
{
public class StatusRepository: Repository
    {   
        //create a method
        public List<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                string sql = "SELECT p.FirstName, p.LastName, ps.StatusDescription FROM persondatabase.person p INNER JOIN persondatabase.personstatus ps ON p.PersonStatusID = ps.PersonStatusID"; //works

                return dbConnection.Query<Status>(sql,commandType:CommandType.Text).ToList();
            }
        }

public void Insert(Status status)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                string sql = "INSERT INTO persondatabase.person (person.FirstName, person.LastName, person.PersonStatusID) values (@FirstName,@LastName,@PersonStatusID);"; //works

                /*dbConnection.Execute(sql, new {PersonID = statusRepository.PersonID, FirstName = statusRepository.FirstName, LastName = statusRepository.LastName, PersonStatusID = statusRepository.PersonStatusID},commandType:CommandType.Text);*/

                 dbConnection.Execute(sql, new {FirstName = status.FirstName, LastName = status.LastName, PersonStatusID = status.PersonStatusId},commandType:CommandType.Text);
            }
        }


    }
}