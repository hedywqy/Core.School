using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Core.School.Core.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }

        [DisplayName("姓名")]
        public  string RealName { get; set; }
        [DisplayName("注册时间")]
        public DateTime EnrollmentDate { get; set; }
        public  ICollection<Enrollment> Enrollments { get; set; }
    }
}