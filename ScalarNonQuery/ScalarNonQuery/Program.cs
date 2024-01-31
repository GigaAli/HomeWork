using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

var builder = new ConfigurationBuilder();
builder.AddJsonFile("appsetting.json");

var config = builder.Build();
using SqlConnection conn = new(config.GetConnectionString("Default"));


var command = new SqlCommand("insert into Teachers(FirstnName,LastName) values(N'Ali',N'Shirinov')", conn);
command.ExecuteNonQuery();

command = new SqlCommand("UPDATE Teachers SET FirstName = N'Ali', LastName = N'Shaxbazov' WHERE ID = 1", conn);
command.ExecuteNonQuery();

command = new SqlCommand("DELETE FROM Teachers WHERE ID = 1", conn);
command.ExecuteNonQuery();


var command2 = new SqlCommand("SELECT COUNT(LastName) FROM Teachers", conn);
command2.ExecuteScalar();

command2 = new SqlCommand("SELECT MAX(Salary) FROM Teachers", conn);
command2.ExecuteScalar();

command2 = new SqlCommand("SELECT SUM(Premium) FROM Teachers", conn);
command2.ExecuteScalar();