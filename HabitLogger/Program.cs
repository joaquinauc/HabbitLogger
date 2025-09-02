using HabbitLogger;

DatabaseFunctions databaseFunctions = new();

databaseFunctions.CreateHabitTable("habit");
HabitInterface.MainMenu();
