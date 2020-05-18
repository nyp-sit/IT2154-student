using System;
namespace DebugWithCompiler {

    class Person {
        private string firstname;
        private string lastname;
        private char gender;

        public Person(string firstname, string lastname, char gender) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
        }

        public string Greet() {
            if ((this.gender = "m") || (this.gender = "M")) {
                return "Mr " + this.FirstName + " " + this.LastName;
            } else {
                return "Ms " + this.FirstName + " " + this.LastName;
            }
        }
        public string FirstName() {
            return this.firstname;
        }

        public string LastName() {
            return this.lastname;
        }

    }
    class Program  {
        static void Main(string[] args) {
            Person p1 = new Person("Celine", "Dion", 'f');
            Console.WriteLine($"Dear {p1.Greet()}");            
        }

    }
}
