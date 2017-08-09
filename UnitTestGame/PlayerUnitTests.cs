using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System.Collections.Generic;

namespace UnitTestGame
{
    [TestClass]
    public class PlayerUnitTests
    {
        [TestMethod]
        public void TestPlayerArmyDecleration()
        {
            var player = new Player("Name", new Army(army));

            Assert.AreEqual(unit.GetType(), player.Army.GetFirstUnit().GetType());
        }
    }
}
