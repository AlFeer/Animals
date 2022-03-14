using System;


namespace Animals.Models
{
    public class Animals
    {
        public string name;
        public string sort;
        public string type;
        public int age;
        public int legsCount;

        public Animals(string nameofAnimal, string sort, string type)
        {

            this.name = nameofAnimal;
            this.sort = sort;
            this.type = type;
            
        }
        public Animals(string nameofAnimal, string sort, string type, int age) : this(nameofAnimal, sort, type)
        {
            this.age = age;
        }

        public Animals(string nameofAnimal, string sort, string color, int age, int legsCount) : this(nameofAnimal, sort, color, age)
        {
            this.legsCount = legsCount;
        }
    }
}
