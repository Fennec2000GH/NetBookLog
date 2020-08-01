
using System;
using System.Diagnostics;
using System.Data.SQLite;

namespace NetBookLog {
    public sealed class Database {
        public void db_setup () {
            SQLiteConnection conn = new SQLiteConnection();
            // conn.Database
            string stmt = @"
            CREATE TABLE `Book` ( +
            id PRIMARY NOT NULL,
            title VARCHAR(255) NOT NULL,
            author VARCHAR(255),
            genre VARCHAR(255),
            notes MESSAGE_TEXT
            )";
            conn.CreateCommand();
            
        }
    }
}