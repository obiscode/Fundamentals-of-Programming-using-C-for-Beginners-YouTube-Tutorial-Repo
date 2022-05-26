using System;

namespace GetNSetProperties
{
    class Person
    {
        private string name; //field

        public string Name //property
        { get; set; }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Obinna";
            Console.WriteLine(myObj.Name);
        }
    }
}
