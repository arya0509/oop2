using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person Ian = new person(1,"Ian","Brooks","Red",30,true);
            person Gina = new person(2, "Gina", "James", "Green", 18, false);
            person Mike = new person(3 ,"Mike", "Briscoe", "Blue", 45, true);
            person Mary = new person(4, "Mary", "Beals", "yellow", 28, true);
            Gina.DisplayPersonInfo();
            Mike.getInfo();

            Ian.ChangefavoriteColour();

            Ian.DisplayPersonInfo();

            Console.WriteLine($"Mary Beals Age in 10 years is: {Mary.GetAgeInTenYears()}");

            relation relation1= new relation("Gina","Mary","Sisterhood");
            relation relation2 = new relation("Ian","Mike","Brotherhood");

            relation1.ShowRelationShip();
            relation2.ShowRelationShip();

           

            List<person> personList=new List <person>{ Ian,Gina,Mike,Mary};
            

            string Mstart="";

            //method to get avg age
             double getAverage(List<person> person)
            {
                double count = 0;
                int total = 0;
                foreach (person personItem in person)
                {
                    count++;
                    total += personItem.age;
                }

                double AvgAge = total / count;
                return AvgAge;
            }


            
            //method to find the youngest and the oldest

            void GetYoungestAndOldest(List<person> personList)

            {
                int PreviousYoungerPersonAge = 100;
                int PreviousOlderPersonAge = 0;
                string youngest = "";
                string oldest = "";

                foreach (person person in personList)
                {



                    if (person.age <= PreviousYoungerPersonAge)
                    {
                        PreviousYoungerPersonAge = person.age;
                        youngest = person.firstName;
                    }
                    if (person.age >= PreviousOlderPersonAge)
                    {
                        PreviousOlderPersonAge = person.age;
                        oldest = person.firstName;
                    }



                }

                Console.WriteLine($"The youngest person is {youngest} ");
                Console.WriteLine($"The oldest person is {oldest} ");

            }

            //method to get the name of the person whose name starts with an m

            void Mname(List<person> personList)
            {

                foreach (person person in personList)
                {
                    if (person.firstName[0].Equals('M'))
                    {
                        
                        person.getInfo();
                    }
                }
            }

            //method to get the info of the person that likes the colour blue

            void GetBlueName(List<person> personList)
            {

                foreach (person person in personList)
                {
                    if (person.favoriteColour.Equals( "Blue"))
                    {
                        
                        person.getInfo();
                    }
                }
            }
            Console.WriteLine($"Average age is : {getAverage(personList)}");
            GetYoungestAndOldest(personList);
            Mname(personList);
            GetBlueName(personList);




        }
    }
}
