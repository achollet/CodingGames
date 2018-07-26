using System;
using System.Collections.Generic;

namespace Challenges
{
    #region classes definition

    public class FamilyTreeNode
    {
        public Person Person { get; set; }
        public List<Person> Children { get; set; }
        public Person Parent { get; set; }

        public FamilyTreeNode(Person person)
        {
            Person = person;
            Children = new List<Person>();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        
    }

    #endregion

    #region business logic
    public class OrderOfSucessionBusiness
    {

    }
    #endregion
}
