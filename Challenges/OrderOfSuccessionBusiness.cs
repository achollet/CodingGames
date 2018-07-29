using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenges.OrderOfSucession
{
    #region classes definition

    public class FamilyTreeNode
    {
        public string Name { get; set; }
        public List<FamilyTreeNode> Children { get; set; }
        public string Parent { get; set; }

        public FamilyTreeNode(){}
        public FamilyTreeNode(string personName)
        {
            Name = personName;
            Children = new List<FamilyTreeNode>();
        }
    }

    #endregion

    #region business logic
    public class OrderOfSucessionBusiness
    {
        public FamilyTreeNode CreateFamilyTreeFromListOfFamilyMembers(List<string[]> familyMembers)
        {
            var headOfFamily = familyMembers.FirstOrDefault(m => string.IsNullOrEmpty(m[1]) || string.IsNullOrWhiteSpace(m[1]));
            var headOfFamilyTree = new FamilyTreeNode(headOfFamily[0])
            {
                Parent = headOfFamily[1]
            };
            familyMembers.Remove(headOfFamily);
            PopulateNodeChildren(headOfFamilyTree, familyMembers);

            return headOfFamilyTree;
        }

        private void PopulateNodeChildren(FamilyTreeNode familyTreeNode, IEnumerable<string[]> familyMembers)
        {
            var nodeChildren = new List<string[]>();
            foreach (var member in familyMembers)
            {
                if (member[1] == familyTreeNode.Name)
                {
                    var child = new FamilyTreeNode(member[0]){Parent =member[1]};
                    PopulateNodeChildren(child, familyMembers);
                    familyTreeNode.Children.Add(child);
                }
            }
        }
    }
    #endregion
}
