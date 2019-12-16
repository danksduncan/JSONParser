using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }
    }
}
