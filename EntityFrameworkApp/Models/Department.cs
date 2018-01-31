using System.Collections.Generic;

namespace EntityFrameworkApp.Models
{
    public class Department
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Student> Students { get; set; }
    }
}
