using System.Collections;
using System.Collections.Generic;
using Core.School.Application.EnumType;

namespace Core.School.Core.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }

        public  string Title { get; set; }

        public int Credits { get; set; }

        public CourseGrade Grade { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}