using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalcial_app
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string fname, string mname, string lname,
                      string cityName, string stateName)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
            City = cityName;
            State = stateName;
        }

        // Return the first and last name.
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname,
                                out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }

    // The example displays the following output:
    //    Hello John Adams of Boston, MA!

    public class TuffleTest
    {
        public void Execute()
        {
            var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object.
            var (fName, lName, city, state) = p;
            Console.WriteLine($"Hello {fName} {lName} of {city}, {state}!");

            // Dictionary와 디컨스트럭션 예제
            Dictionary<string, int> snapshotCommitMap = new(StringComparer.OrdinalIgnoreCase)
            {
                ["https://github.com/dotnet/docs"] = 16_465,
                ["https://github.com/dotnet/runtime"] = 114_223,
                ["https://github.com/dotnet/installer"] = 22_436,
                ["https://github.com/dotnet/roslyn"] = 79_484,
                ["https://github.com/dotnet/aspnetcore"] = 48_386
            };

            foreach (var (rep1o, commitCount) in snapshotCommitMap)
            {
                Console.WriteLine(
                    $"The {rep1o} repository had {commitCount:N0} commits as of November 10th, 2021.");
            }
            

        }

        
    }
}