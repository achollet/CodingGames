using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class OrderOfSuccessionBusinessTest
    {
        private List<Person> _familyMembers;
        private OrderOfSucessionBusiness _orderOfSuccessionBusiness;

        [[TestInitialize]
        public void InitializeOrderOfSuccessionBusinessTest()
        {
            _orderOfSuccessionBusiness = new OrderOfSucessionBusiness();

            _familyMembers = new List<Person>
            {
                new Person{Name = "Elizabeth", ParentName = string.Empty},
                new Person{Name = "Charles", ParentName = "Elizabeth"},
                new Person{Name = "William", ParentName = "Chales"}
            };
        }]


        [TestMethod]
        public void CreateFamilyTreeFromListOfFamilyMembers_Test_ReturnOk()
        {
        }
    }
}

// Elizabeth - 1926 - Anglican F
// Charles Elizabeth 1948 - Anglican M
// William Charles 1982 - Anglican M