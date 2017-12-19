using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System.Linq;

[TestFixture]
public class ActionMasterTest : MonoBehaviour
{
    //private List<int> pinFalls;
    //private ActionMaster.Action tidy = ActionMaster.Action.Tidy;
    //private ActionMaster.Action reset = ActionMaster.Action.Reset;
    //private ActionMaster.Action endTurn = ActionMaster.Action.EndTurn;
    //private ActionMaster.Action endGame = ActionMaster.Action.EndGame;

    //[SetUp]
    //public void Setup()
    //{
    //    pinFalls = new List<int>();
    //}

    //[Test]
    //public void PassingTest()
    //{
    //    Assert.AreEqual(1, 1);
    //}

    //[Test]
    //public void T01OneStrikeReturnsEndTurn()
    //{
    //    pinFalls.Add(10);
    //    Assert.AreEqual(endTurn, ActionMaster.NextAction(pinFalls));
    //}

    //[Test]
    //public void T02bowl8returnstidy()
    //{
    //    pinFalls.Add(8);
    //    Assert.AreEqual(tidy, ActionMaster.NextAction(pinFalls));
    //}

    //[Test]
    //public void T03Bowl2_8SpareReturnsEndTurn()
    //{
    //    int[] thisRolls = { 2, 8 };
    //    Assert.AreEqual(endTurn, ActionMaster.NextAction(thisRolls.ToList()));
    //}

    //[Test]
    //public void T04BowlStrikeInLastFrame()
    //{
    //    int[] thisRolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10 };

    //    Assert.AreEqual(reset, ActionMaster.NextAction(thisRolls.ToList()));
    //}

    //[Test]
    //public void T05BowlSpareInLastFrame()
    //{
    //    int[] thisRolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9 };

    //    Assert.AreEqual(reset, ActionMaster.NextAction(thisRolls.ToList()));
    //}

    //[Test]
    //public void T06RollsEndGame()
    //{
    //    int[] thisRolls = { 8, 2, 7, 3, 3, 4, 10, 2, 8, 10, 10, 8, 0, 10, 8, 2, 9 };

    //    Assert.AreEqual(endGame, ActionMaster.NextAction(thisRolls.ToList()));
    //}

    //[Test]
    //public void T07GameEndsAtBowl20()
    //{
    //    int[] thisRolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };


    //    Assert.AreEqual(endGame, ActionMaster.NextAction(thisRolls.ToList()));
    //}


    //[Test]
    //public void T08Bowl5AfterStrikeOn20()
    //{
    //    int[] thisRolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 5 };

    //    Assert.AreEqual(tidy, ActionMaster.NextAction(thisRolls.ToList()));

    //}

    //[Test]
    //public void T08BowlZeroAfterStrikeOn20()
    //{
    //    int[] thisRolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 0 };


    //    Assert.AreEqual(tidy, ActionMaster.NextAction(thisRolls.ToList()));

    //}

    //[Test]
    //public void T09BowlZeroInFirstBowl()
    //{
    //    int[] thisRolls = { 0, 10, 5, 1 };


    //    Assert.AreEqual(endTurn, ActionMaster.NextAction(thisRolls.ToList()));

    //}

    //[Test]
    //public void T10TestTurkey()
    //{
    //    int[] thisRolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 10, 10 };

    //    Assert.AreEqual(endGame, ActionMaster.NextAction(thisRolls.ToList()));
    //}

    //[Test]
    //public void T11TestZeroAndOne()
    //{
    //    int[] thisRolls = { 0, 1 };

    //    Assert.AreEqual(endTurn, ActionMaster.NextAction(thisRolls.ToList()));

    //}

}