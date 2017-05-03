﻿using System.Data.OleDb;

namespace DatabaseConnections.OleDb
{
    public class OleDbDatabase : Database
    {
        public OleDbDatabase(OleDbConnection connection) 
            : base(new OleDbConnectionWrapper(connection))
        {
        }
    }
}
