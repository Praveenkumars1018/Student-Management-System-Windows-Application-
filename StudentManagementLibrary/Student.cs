using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace StudentManager
{
    public interface IStudentManager
    {
        void EnrollStudent(int id, string name, int age);
        void DeleteStudent(int id);
        Student FindStudentById(int studentId);
        List<Student> GetAllStudents();
        void SaveData(string filePath);
        void LoadData(string filePath);
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Dictionary<string, int> CourseGrades { get; set; } = new Dictionary<string, int>();

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        /// <summary>
        /// this function is having the Implementation for upgrading the grades for the courses
        /// </summary>
        /// <param name="course"></param>
        /// <param name="grade"></param>
        public void UpdateGrade(string course, int grade)
        {
            if (CourseGrades.ContainsKey(course))
            {
                // Update existing course grade
                CourseGrades[course] = grade;
            }
            else
            {
                // Add new course grade
                CourseGrades.Add(course, grade);
            }
        }

        /// <summary>
        /// This function is having the implementation for getting average of grades
        /// </summary>
        /// <returns></returns>
        public double GetAverageGrade()
        {
            if (CourseGrades.Count == 0)
                return 0;
            return CourseGrades.Values.Average();
        }

        public bool HasPassed()
        {
            return GetAverageGrade() >= 60;
        }
    }


    /// <summary>
    /// StudentManager class was having the implementations for the Adding student, Deleting student, Serialization and deserialization
    /// </summary>
    public class StudentManager : IStudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }

        public void EnrollStudent(int id, string name, int age)
        {
            if (students.Any(s => s.Id == id))
            {
                throw new InvalidOperationException("Student with this ID already exists.");
            }
            students.Add(new Student(id, name, age));
        }

        public void DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            else
            {
                throw new InvalidOperationException("There is no student with this ID.");
            }
        }

        public Student FindStudentById(int studentId)
        {
            return students.FirstOrDefault(s => s.Id == studentId);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public void SaveData(string filePath)
        {
            var json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void LoadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
            }
            else
            {
                throw new FileNotFoundException("Data file not found.");
            }
        }
    }
}