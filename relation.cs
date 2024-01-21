using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class relation

    {
        string person1;
        string person2;
        string RelationshipType;

        public  relation( string person1,string person2,string Relation)
        {
            this.person1 = person1;
            this.person2 = person2;
            this.RelationshipType = Relation;
        }

        public void ShowRelationShip()
        {
            Console.WriteLine($"Relationship between {this.person1} and {this.person2} is : {this.RelationshipType}");

        }
    }
}
