//1)Setup and Connection:
//Write a C# console application that connects to the database using ADO.NET.
using System.Data.SqlClient;

string ConnectionString = "Server=.;Database = Practices; Integrated Security = true";
var conn = new SqlConnection(ConnectionString);
conn.Open();
//Create a simple database with one table(e.g., Persons with columns Id, Name, and Age).
//Basic Select Query:
//Extend the application to execute a SELECT query to retrieve all rows from the Persons table.
//Display the results in the console.


//var query = "CREATE TABLE Persons(ID INT PRIMARY KEY IDENTITY,NAME NVARCHAR(30),AGE DECIMAL)";
//SqlCommand cmd = new SqlCommand(query, conn);
//var execute = cmd.ExecuteNonQuery();


//Insert Data:
//var query = "INSERT INTO Persons VALUES ('Kamil', 23), ('Rubabe', 28), ('Leyla', 24), ('Hasan', 29), ('Huseyn', 32)";
//var cmd = new SqlCommand(query, conn);
//cmd.ExecuteNonQuery();


//Write a method in the console application to insert a new student into the Persons table.

void InsertStudent(string name, int age)
{
    var query = $"INSERT INTO Persons VALUES ('{name}', {age})";
    var cmd = new SqlCommand(query, conn);
    cmd.ExecuteNonQuery();
}

void Select()
{
    var query = "SELECT * FROM Persons";
    var cmd = new SqlCommand(query, conn);
    var reader = cmd.ExecuteReader();

    while (reader.Read())
    {
        for(int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write(reader[i] + "\t");
        }
        Console.WriteLine(" ");
    }
}

//Prompt the user to enter the student's name and age, then save it to the database.
//Console.WriteLine("What is Student's Name?");
//string studentName = Console.ReadLine();
//Console.WriteLine("How old are you?");
//int studentAge = Convert.ToInt32(Console.ReadLine());
//InsertStudent(studentName, studentAge);

//Select();

//Parameterized Queries:
//Modify the insert method to use parameterized queries to prevent SQL injection.
//Ensure the user inputs are correctly handled and inserted into the database.

//Medium
//Update Data:
//Write a method to update the age of a person given their Id.
//Use parameterized queries for this operation.
void UpdateAge(int ID, int newage)
{
    var query = $"UPDATE Persons SET Age = {newage} WHERE ID = {ID}";
    var cmd = new SqlCommand(query, conn);
    cmd.ExecuteNonQuery();
}

//Console.WriteLine("Student ID");
//int studentID = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("New Age:");
//int studentNewAge = Convert.ToInt32(Console.ReadLine());
//UpdateAge(studentID, studentNewAge);
//Select();

//Delete Data:
//Write a method to delete a student record based on the Id.
//Confirm the deletion with the user before executing it.
void DeleteData(int ID)
{
    var query = $"DELETE FROM Persons WHERE ID = {ID}";
    var cmd = new SqlCommand(query, conn);
    cmd.ExecuteNonQuery();
}
Console.WriteLine("Student ID");
int studentID1 = Convert.ToInt32(Console.ReadLine());
DeleteData(studentID1);
Select();
conn.Close();