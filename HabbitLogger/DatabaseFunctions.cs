using Microsoft.Data.Sqlite;

namespace HabbitLogger;

internal class DatabaseFunctions
{
    internal void CreateHabitTable()
    {
        using (var connection = new SqliteConnection("Data Source=habit_logger.db"))
        {
            connection.Open();

            var command = connection.CreateCommand();
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

    internal void Insert(SqliteCommand command)
    {

    }

    internal void Delete(SqliteCommand command)
    {

    }
}
