using Microsoft.Data.SqlClient;
class StudentConnection{
    public static void Main(String [] args){
        string querry = "SELECT * FROM COURSES";
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=CollegeDB;Trusted_Connection=true;TrustServerCertificate=true;";
        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        System.Console.WriteLine("Connection established");
        SqlCommand command = new SqlCommand(querry, connection);
        SqlDataReader reader = command.ExecuteReader();
        while(reader.Read()){
            System.Console.WriteLine(reader["CourseID"]+" "+reader["CourseName"]+" "+reader["DeptID"]);
        }
        reader.Close();
        connection.Close();
    }
}