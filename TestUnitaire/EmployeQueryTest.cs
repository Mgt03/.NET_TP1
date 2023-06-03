using System.Linq;
using Bibliotheque;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitaire
{
    [TestClass]
    public class EmployeQueryTest
    {
        
        
        [TestMethod]
        public void TestGetAll()
        {
            Context context = new Context();
            var employeQuery = new BusinessLogicLayer.Queries.EmployeQuery(context);
            
            var list = employeQuery.GetAll();
            
            Assert.AreEqual(2, list.Count());
        }
        
        [TestMethod]
        public void TestGetByID()
        {
            Context context = new Context();
            var employeQuery = new BusinessLogicLayer.Queries.EmployeQuery(context);
            
            var list = employeQuery.GetByID(1);
            
            Assert.AreEqual(1, list.Count());
        }
    }
}