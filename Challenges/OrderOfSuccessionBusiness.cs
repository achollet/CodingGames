using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenges
{
    #region classes definition

    public class FamilyTreeNode
    {
        public Person Person { get; set; }
        public List<FamilyTreeNode> Children { get; set; }
        public Person Parent { get; set; }

        public FamilyTreeNode(Person person)
        {
            Person = person;
            Children = new List<FamilyTreeNode>();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ParentName { get; set; }
        // public int YearOfBirth { get; set; }
        // public string YearOfDeath { get; set; }
        // public string Religion {get ; set ;}
        // public string Gender { get; set; }
    }

    #endregion

    #region business logic
    public class OrderOfSucessionBusiness
    {
        public FamilyTreeNode CreateFamilyTreeFromListOfFamilyMembers(List<Person> familyMembers)
        {
            var headOfFamilyTree = familyMembers.First(m => (String.IsNullOrEmpty(m.ParentName) || String.IsNullOrWhiteSpace(m.ParentName)));

            var headOfFamilyTreeNode = new FamilyTreeNode(new Person());

            if (headOfFamilyTree != null)
            {
                headOfFamilyTreeNode.Person.Name = headOfFamilyTree.Name;
            }

            PopulateChildrenOfNode(headOfFamilyTree, familyMembers);


            return headOfFamilyTreeNode
        }

        private void PopulateChildrenOfNode(Person familyTreeNode, IEnumerable<Person> familyMembers)
        {
            var children = familyMembers.Where(m => m.ParentName == familyTreeNode.Name);

            if(children.Any())
            {
                foreach(var child in children)
                {
                    var childNode = new FamilyTreeNode(new Person)
                }
            }
        }
    }
    #endregion
}
