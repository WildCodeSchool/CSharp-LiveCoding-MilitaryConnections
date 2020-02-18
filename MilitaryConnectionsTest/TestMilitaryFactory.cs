using NUnit.Framework;
using MilitaryConnections;
using System;

namespace MilitaryConnectionsTest
{
    public class MilitaryFactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGruntCreation()
        {
            AbstractMilitary grunt = MilitaryFactory.Create("Bernard", 10, 5);

            Assert.AreSame(typeof(Grunt), grunt.GetType());
        }

        [Test]
        public void TestSergeantCreation()
        {
            AbstractMilitary sergeant = MilitaryFactory.Create("Hubert", 30, 12);

            Assert.AreSame(typeof(Sergeant), sergeant.GetType());
        }

        [Test]
        public void TestCaptainCreation()
        {
            AbstractMilitary sergeant = MilitaryFactory.Create("Jean-Paul", 50, 25);

            Assert.AreSame(typeof(Captain), sergeant.GetType());
        }

        [Test]
        public void TestGeneralCreation()
        {
            AbstractMilitary sergeant = MilitaryFactory.Create("Eugène", 81, 65);

            Assert.AreSame(typeof(General), sergeant.GetType());
        }

        [Test]
        public void TestWrongArguments()
        {
            Assert.Throws(typeof(ArgumentException), delegate
            {
                AbstractMilitary military = MilitaryFactory.Create("Test", -10, 0);
            });
        }
    }
}