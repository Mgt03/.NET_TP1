using System.Collections.Generic;
using Bibliotheque;
using Bibliotheque.Entity;
using BusinessLogicLayer.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitaire
{
    [TestClass]
    public class EmployeCommandTest
    {
        [TestMethod]
        public void TestAjouterEmploye()
        {
            Context context = new Context();
            EmployeCommand employeCommand = new EmployeCommand(context);
            
            var employe = new Employe()
            {
                Nom = "Test",
                Prenom = "Test",
                DateNaissance = new System.DateTime(1990, 1, 1),
                Biographie = "Test",
                Anciennete = 1,
                Experiences = new List<Experience>()
            };
            
            var result = employeCommand.Ajouter(employe);
            
            Assert.AreEqual(1, result);
        }
        
        [TestMethod]
        public void TestModifierEmploye()
        {
            Context context = new Context();
            EmployeCommand employeCommand = new EmployeCommand(context);
            
            var employe = new Employe()
            {
                Id = 1,
                Nom = "Test",
                Prenom = "Test",
                DateNaissance = new System.DateTime(1990, 1, 1),
                Biographie = "Test",
                Anciennete = 1,
                Experiences = new List<Experience>()
            };
            
            var result = employeCommand.Modifier(employe);
            
            Assert.AreEqual(1, result);
        }
        
        [TestMethod]
        public void TestSupprimerEmploye()
        {
            Context context = new Context();
            EmployeCommand employeCommand = new EmployeCommand(context);
            
            var employe = new Employe()
            {
                Id = 1,
                Nom = "Test",
                Prenom = "Test",
                DateNaissance = new System.DateTime(1990, 1, 1),
                Biographie = "Test",
                Anciennete = 1,
                Experiences = new List<Experience>()
            };
            
            var result = employeCommand.Supprimer(employe);
            
            Assert.AreEqual(1, result);
        }
    }
}