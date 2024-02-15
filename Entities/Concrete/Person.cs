using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person  //Maske takibindeki vatandaşları takip edecek
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
