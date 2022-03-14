using System;

namespace Animals.Models
{
    public class Horse : Animals
    {
        public string horseName;
        public string color;
        public int height;

        public Horse(string horseName, string type, int height, string name, string sort, string color, int age, int legsCount) : base(name, sort, type, age, legsCount)
        {
            this.horseName = horseName;
            this.type = type;
            this.height = height;
            this.name = name;
            this.sort = sort;
            this.color = color;
            this.age = age;
            this.legsCount = legsCount;
        }
       
    }
}
