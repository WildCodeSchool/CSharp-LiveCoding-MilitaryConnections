using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MilitaryConnections;
using System.Linq;

namespace MilitaryConnectionsTest
{
    [TestFixture]
    class TestMilitaryComposite
    {
        private General _general;
        private Captain _captain;
        private Sergeant _sergeant;
        private Grunt _grunt;

        [SetUp]
        public void SetUp()
        {
            _general = new General("Asshole", 100, 65);
            _captain = new Captain("Moron", 79, 64);
            _sergeant = new Sergeant("Dumbass", 25, 15);
            _grunt = new Grunt("Troufion", 1, 1);

            _general.Subordinates.Add(_captain);
            _captain.Subordinates.Add(_sergeant);
            _sergeant.Subordinates.Add(_grunt);
        }

        [Test]
        public void TestAverageStupidity()
        {
            List<AbstractMilitary> militaries = _general.DivisionSubordinates.ToList();
            militaries.Add(_general);
            double averageStupidity = militaries.Select(military => military.Stupidity).Average();
            double expectedStupidity = (100.0 + 79 + 25 + 1) / 4d;

            Assert.AreEqual(expectedStupidity, averageStupidity);
        }
    }
}
