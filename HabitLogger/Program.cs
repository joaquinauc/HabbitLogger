using HabbitLogger;

DatabaseFunctions databaseFunctions = new();

databaseFunctions.CreateTable("habit");
databaseFunctions.CreateTable("habit_log");

HabitInterface.MainMenu();
