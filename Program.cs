using System;
using System.Collections.Generic;
using System.Linq;

namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Jeffry",
                                LastName = "Babb",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Joe",
                                LastName = "Smith",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Jane",
                                LastName = "Doe",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },   

                                                        new Student()
                            {
                                FirstName = "Marion",
                                LastName = "McGovern",
                                PhoneNumber = "568-222-1010",
                                Email = "marion_mcgovern@buffs.wtamu.edu",
                                Role = "Junior"
                            },                        
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}

/*using System;
using System.Collections.Generic;
namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

            List<Student> students = new List<Student>()
            {
               // new Student
                ///Add some new students here
//db.Students.AddRange(students)
//var students = db.Students.ToList()
//for each (student s in students)
// can you create entities for the Buffteks stuff
//explore the find function
//can run a linq method called find.

// study Babb's code on his git hub - do this for the buff teks problem

//feed


            Student s = new Student()
            {
                FirstName = "Jeff",
                LastName = "Babb",
                PhoneNumber = "123-555-1334",
                Email = "sdfgs@ffgsf.org"
            };
            db.Students.Add(s);
            
            try
            {
                db.SaveChanges();
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            }
            
        }
    }
}
*/