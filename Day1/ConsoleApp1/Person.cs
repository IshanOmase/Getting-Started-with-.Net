using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person
    {
        //data members
        private static int count=0;
        private int id;
        private string name;
        private int age;

        public int Id { 
            get { return id; } 
            set { id = value; }
        }    

        //getter and setter
        public string Name { get { return name; } set {  name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Count { get { return count; } }


        public Person() { }
        public Person(int id, string name, int age) {
            this.id = id;
            this.name = name;   
            this.age = age;
            count++;
        }       

        ~Person() {
            count--;
        }

        public override string ToString() {
            return base.ToString() + "["
                + "ID: " + id + " |Name: " + name +
                " |Age: " + age +"]";
        }

    }
}
