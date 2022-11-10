using FakeStudentAPI.Model;
using System.Collections.Generic;

namespace FakeStudentAPI.Services;

public class StudentService
{
    private string[] Noms = new string[]
    {
        "Hellscream",
        "Proudmoore",
        "Wildhammer"
    };

    private string[] Prenoms = new string[]
    {
        "Garrosh",
        "Jaina",
        "Falstad"
    };
    
    public Student[] Students;

    public StudentService()
    {
        Students = GenerateList().ToArray();
    }

    public IEnumerable<Student> GenerateList()
    {
        int id = 0;

        foreach (string nom in Noms)
        {
            foreach (string prenom in Prenoms)
            {
                yield return (new Student
                {
                    Id = ++id,
                    Nom = nom,
                    Prenom = prenom,
                    Mail = $"{prenom.First()}{nom}@normandiewebschool.fr".ToLower()
                });
            }
        }
    }
}