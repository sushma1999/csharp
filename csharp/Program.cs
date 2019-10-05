using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Fname = "Sush";
            person.Lname = "Ephrin";
            person.Intro();
        }
    }
}
