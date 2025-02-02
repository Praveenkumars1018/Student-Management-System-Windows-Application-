using System;
using System.Collections.Generic;

namespace StudentManager
{
    /// <summary>
    /// Extension method was added to retrieve a student's grades
    /// </summary>
    public static class StudentExtension
    {
        public static string RetrieveGrades(this Student student)
        {
            if (student == null)
            {
                return "There is no student with this id has been enrolled";
            }
            string str = $"Grades of the student '{student.Name}' with id {student.Id} is :\n";
                foreach (var entry in student.CourseGrades) {
                    str += $"{entry.Key}  :  {entry.Value}\n";
                }
            return str;
        }
    }
}
