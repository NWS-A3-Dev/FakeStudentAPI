namespace FakeStudentAPI.Model;

public class Student
{
    public int Id { get; set; }
    public string Nom { get; set; } = String.Empty;
    public string Prenom { get; set; } = String.Empty;
    public string Mail { get; set; } = String.Empty;
}