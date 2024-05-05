// See https://aka.ms/new-console-template for more information

using DeveloperTest;

int menuOption = 0;


while (menuOption != 9)
{
	Console.WriteLine("*********************************************");
	Console.WriteLine("* Please choose your option and press enter *");
	Console.WriteLine("* 1. Add and save integers to database.     *");
	Console.WriteLine("* 2. Show all arguments saved to database   *");
	Console.WriteLine("* 9. Exit program                           *");
	Console.WriteLine("*********************************************");

	var selection = Console.ReadLine();

	if (!int.TryParse(selection, out menuOption))
	{
		Console.WriteLine("You must choose one of the provided options.");
	}

	if (menuOption == 1)
	{
		bool arg1Success = false;
		bool arg2Success = false;

		var argStr1 = "";
		var argStr2 = "";
		int argInt1 = 0;
		int argInt2 = 0;

		while (!arg1Success)
		{
			Console.WriteLine("Enter integer 1: ");
			argStr1 = Console.ReadLine();
			if(string.IsNullOrWhiteSpace(argStr1))
			{
				Console.WriteLine("You did not provide an integer. Try Again");
				continue;
			}

			if(int.TryParse(argStr1, out argInt1))
			{
				arg1Success = true;
			}
			else
			{
				Console.WriteLine("You did not provide an integer. Try Again");
				continue;
			}
		}


		while (!arg2Success)
		{
			Console.WriteLine("Enter integer 2: ");
			argStr2 = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(argStr2))
			{
				Console.WriteLine("You did not provide an integer. Try Again");
				continue;
			}

			if (int.TryParse(argStr2, out argInt2))
			{
				arg2Success = true;
			}
			else
			{
				Console.WriteLine("You did not provide an integer. Try Again");
				continue;
			}
		}


		Console.WriteLine($"Thank you. The result is {argStr1} + {argStr2} = {ExtensionMethods.Add(argInt1, argInt2)}");
		DatabaseManager databaseManager = new DatabaseManager();
		databaseManager.AddArgumentsToDatabase(argInt1 , argInt2, DateTime.Now);

		Console.WriteLine("Saving to database...");
		//TODO: Add arguments to Database
		Console.WriteLine($"Integers {argStr1} and {argStr2} saved to database.");
		Console.WriteLine("");
		Console.WriteLine("");

	}
	else if (menuOption == 2)
	{
		DatabaseManager databaseManager = new DatabaseManager();
		List<Tuple<int, int, DateTime>> allArguments = databaseManager.ReadAllArgumentsFromDatabase();


		Console.WriteLine($"There is a total of {allArguments.Count} arguments in the database.");
		Console.WriteLine("Argument1\tArgument2\tCreated");

		foreach (var argument in allArguments)
		{
			Console.WriteLine($"{argument.Item1}\t\t{argument.Item2}\t\t{argument.Item3}");
		}
		Console.WriteLine("");
		Console.WriteLine("");
	}
	else if (menuOption == 9)
	{
		break;
	}
}