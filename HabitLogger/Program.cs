using HabbitLogger;

DatabaseFunctions databaseFunctions = new();
HabitInterface habitInterface = new();

databaseFunctions.CreateTable("habit");
databaseFunctions.CreateTable("habit_log");

habitInterface.MainMenu();
