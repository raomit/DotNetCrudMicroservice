﻿namespace DotNetCrudMicroservice.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? RecoveryEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation property representing the Branch the student is enrolled in - one student can belong to one branch - one to one relationship
        public virtual Branch? Branch { get; set; }
    }
}
