
using System;
using System.Diagnostics;
using System.Data.SQLite;

namespace NetBookLog {
    public sealed class Database {
        public void db_setup () {
            SQLiteConnection conn = new SQLiteConnection();
            string stmt = @"CREATE DATABASE IF NOT EXISTS `eBookDB`";
            SQLiteCommand cmd = new SQLiteCommand(commandText: stmt, connection: conn);
            cmd.ExecuteNonQuery();
            
            cmd.CommandText = @"USE `eBookDB`";
            cmd.ExecuteNonQuery();

            stmt = @"
            CREATE TABLE IF NOT EXISTS `Book` ( +
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