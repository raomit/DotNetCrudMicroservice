﻿namespace DotNetCrudMicroservice.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? Description { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        // Collection navigation property representing the students enrolled in the branch - one branch can have many students - one to many relationship
        public ICollection<Student>? Students { get; set; }
    }
}
