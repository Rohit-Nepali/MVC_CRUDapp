using System.ComponentModel.DataAnnotations;

namespace CRUDapplication.Models.Entity
{
    public class Teacher
    {
        [Key]
        public int Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
