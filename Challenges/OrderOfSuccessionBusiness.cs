using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenges
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
            throw new NotImplementedException();
        }

        private void PopulateNodeChildren(FamilyTreeNode familyTreeNode, IEnumerable<string[]> familyMembers)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
