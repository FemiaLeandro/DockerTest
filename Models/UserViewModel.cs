using System;

namespace DockerTest.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}