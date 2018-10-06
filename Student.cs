using System;

namespace Buffteks3
{
    public class Student
    {
        //PK
        public int StudentID{ get; set; }
        //First Name
        public string FirstName { get; set; }
        //Last name
        public string LastName { get; set; }        
        //phone
        public string PhoneNumber { get; set; }
        //email
        public string Email {get; set; }
        //role
        public string Role { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

    }

}

/*using System;

namespace Buffteks3
{
    class Student
    {
        static void (string[] args)
        {
       
        public int StudentID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
        }
    }
}
*/