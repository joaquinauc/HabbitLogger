using Microsoft.Data.Sqlite;
using System.Data;

namespace HabbitLogger;

internal class DatabaseFunctions
{
    internal void CreateHabitTable()
    {
        bool tableExist = false;
        
        using (var connection = new SqliteConnection("Data Source=habit_logger.db"))
        {
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table';";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) == "habit") tableExist = true; break;
                }
            }

            if (!tableExist)
            {
                command.CommandText =
                @"
                    CREATE TABLE habit (
                        id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL,
                        quantity INTEGER NOT NULL,
                        unit TEXT NOT NULL
                    );
                ";

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
