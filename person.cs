using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class person
    {
        int personId;
        public string firstName;
        string lastName;
        public string favoriteColour;
        public int age;
        bool isWorking;

        public person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;


        }

        //method to get persos info
        public void getInfo() {
            string[] info = { "PersonId", "FirstName", "LastName", "FavoriteColour", "age", "isWorking" };
            for (int i = 0; i < this.ToString().Count; i++)
            {
                Console.WriteLine($"{info[i]}:{this.ToString()[i]}");
            }
        }
        
    public void DisplayPersonInfo()
        {

            string Name = this.firstName + this.lastName;
            Console.WriteLine($"{personId}: {Name}\'s favorite color is {this.favoriteColour}");
        }
        public void ChangefavoriteColour()

        {
            this.favoriteColour = "white";
        }

        public int GetAgeInTenYears()
        {
            return this.age + 10;
        }

        public List<string> ToString()
        {
            List<string> list = new List<string> { this.personId.ToString(), this.firstName, this.lastName, this.favoriteColour, this.age.ToString(), this.isWorking.ToString() };
            return list;
        }



    }
}
