using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class OrderOfSuccessionBusinessTest
    {
        private List<string[]> _familyMembers;
        private OrderOfSucessionBusiness _orderOfSuccessionBusiness;

        [TestInitialize]
        public void InitializeOrderOfSuccessionBusinessTest()
        {
            _orderOfSuccessionBusiness = new OrderOfSucessionBusiness();

            _familyMembers = new List<string[]>
            {
                new string[]{"Elizabeth", string.Empty},
                new string[]{"Charles", "Elizabeth"},
                new string[]{"William", "Chales"}
            };
        }

        [TestMethod]
        public void CreateFamilyTreeFromListOfFamilyMembers_Test_ReturnOk()
        {
            var expect = new FamilyTreeNode("Elizabeth"){
                Children = new List<FamilyTreeNode>{
                    new FamilyTreeNode("Charles"){
                        Parent = "Elizabeth",
                        Children = new List<FamilyTreeNode>()
                        {
                            new FamilyTreeNode("William")
                            {
                                Parent = "Charles"
                            }
                        }
                    }
                }
            };

            var result = _orderOfSuccessionBusiness.CreateFamilyTreeFromListOfFamilyMembers(_familyMembers);

            Assert.AreEqual(expect.Name, result.Name);
            Assert.IsTrue(result.Children.Any());
            Assert.IsTrue(result.Children.Where(c => c.Name == expect.Children[0].Name).Any());
            Assert.IsTrue(result.Children.First(c => c.Name == expect.Children[0].Name).Children.Any());
            Assert.IsTrue(result.Children.First(c => c.Name == expect.Children[0].Name).Children.Where(c => c.Name == expect.Children[0].Children[0].Name).Any());
        }
    }
}

// Elizabeth - 1926 - Anglican F
// Charles Elizabeth 1948 - Anglican M
// William Charles 1982 - Anglican M