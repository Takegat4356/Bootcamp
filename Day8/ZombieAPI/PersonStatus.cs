namespace ZombieAPI
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class PersonStatus
    {
        public int PersonID { get; set; }
        public int PersonStatusID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StatusDescription { get; set; }
    }
}