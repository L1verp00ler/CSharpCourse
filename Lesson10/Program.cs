using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group { Name = "Family" };

            var group2 = new Group { Name = "Other" };

            var person1 = new Person
            {
                FullName = "Maxim",
                Address = "Ivanovo",
                Phone = "8999777555",
                Email = "max@gmail.com",
                Groups = new List<Group> { group1 }
            };

            var person2 = new Person
            {
                FullName = "Andrey",
                Address = "Ivanovo",
                Phone = "8777555333",
                Email = "and@gmail.com",
                Groups = new List<Group> { group1, group2 }
            };

            var db = new PhoneStoreDb();
            db.Database.Delete();

            db.People.Add(person1);
            db.People.Add(person2);
            db.SaveChanges();

            /*
            var query = db.People.Include(p => p.Group);
            Console.WriteLine(query.ToString());
            foreach (var p in query)
            //foreach (var p in db.People)
            {
                Console.WriteLine($"{p.FullName}\t{p.Phone}\t{p.Group.Name}");
            }
            */

            foreach (var p in db.Groups.Include(g => g.People).First().People)
            //foreach (var p in db.People)
            {
                Console.WriteLine($"{p.FullName}\t{p.Phone}\t{p.Groups.Count}");
            }
        }
    }

    class PhoneStoreDb : DbContext
    {
        public IDbSet<Person> People { get; set; }

        public IDbSet<Group> Groups { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public virtual List<Group> Groups { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
