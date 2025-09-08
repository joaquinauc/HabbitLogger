using Microsoft.Data.Sqlite;
using System.Data;

namespace HabbitLogger;

internal class DatabaseFunctions
{
    internal void CreateTable(string table_name)
    {
        List<string> tables = new();
        
        using (var connection = new SqliteConnection("Data Source=habit_logger.db"))
        {
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table';";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add(reader.GetString(0));
                }
            }

            if (tables.BinarySearch(table_name) < 0)
            {
                if (table_name == "habit")
                {
                    command.CommandText =
                    $@"
                        CREATE TABLE {table_name} (
                            id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            quantity_goal INTEGER NOT NULL,
                            unit TEXT NOT NULL
                        );
                    ";
                }
                else if (table_name == "habit_log")
                {
                    command.CommandText =
                    $@"
                        CREATE TABLE {table_name} (
                            id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            quantity INTEGER NOT NULL,
                            goal_achieved BOOLEAN NOT NULL,
                            date DATE NOT NULL
                        );
                    ";
                }

                command.ExecuteNonQuery();
            }
        }
    }

    internal void Insert(SqliteCommand command)
    {

    }

    internal void Delete(SqliteCommand command)
    {

    }
}
