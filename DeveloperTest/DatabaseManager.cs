using System.Configuration;
using System.Data.SqlClient;

namespace DeveloperTest
{
	internal class DatabaseManager
	{
		string connectionString = "";
		public bool AddArgumentsToDatabase(int argument1, int argument2, DateTime createdDateTime)
		{

			connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var query = "INSERT INTO Arguments (Argument1, Argument2, CreatedDT) VALUES (@arg1, @arg2, @createddt)";
				using (var command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@arg1", argument1);
					command.Parameters.AddWithValue("@arg2", argument2);
					command.Parameters.AddWithValue("@createddt", createdDateTime);
					command.ExecuteNonQuery();
				}
			}

			return true;
		}


		public List<Tuple<int, int, DateTime>> ReadAllArgumentsFromDatabase()
		{
			List<Tuple<int, int, DateTime>> arguments = [];
			connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var query = "SELECT Argument1, Argument2, CreatedDT FROM Arguments";
				using (var command = new SqlCommand(query, connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{

							//int arg1 = reader.GetInt32(0);
							//int arg2 = reader.GetInt32(1);
							//DateTime arg3 = reader.GetDateTime(2);
							arguments.Add(new Tuple<int, int, DateTime>(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2)));
							
						}
					}
				}
			}
			return arguments;
		}
	}
}
