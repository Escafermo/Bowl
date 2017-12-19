﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System.Linq;

[TestFixture]
public class ScoreDisplayTest : MonoBehaviour
{
    [Test]
    public void PassingTest()
    {
        Assert.AreEqual(1, 1);
    }

    [Test]
    public void T01Bowl()
    {
        int[] rolls = { 1 };
        string rollsString = "1";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }

    [Test]
    public void T02Strike()
    {
        int[] rolls = { 10 };
        string rollsString = "X ";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }

    [Test]
    public void T03Spare()
    {
        int[] rolls = { 5, 5 };
        string rollsString = "5/";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));

    }

    [Test]
    public void T04SpareAnd1()
    {
        int[] rolls = { 1, 9, 1 };
        string rollsString = "1/1";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }

    [Test]
    public void T05SpareInLastFrame()
    {
        int[] rolls = { 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 9,1, 1};
        string rollsString = "1111111111111111119/1";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }

    [Test]
    public void T06StrikeInLastFrame()
    {
        int[] rolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 1, 1 };
        string rollsString = "111111111111111111X11";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }

    [Test]
    public void T07BowlZero()
    {
        int[] rolls = { 0 };
        string rollsString = "-";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }

    [Test]
    public void T08ZeroSpare()
    {
        int[] rolls = { 0, 10 };
        string rollsString = "-/";
        Assert.AreEqual(rollsString, ScoreDisplay.FormatRolls(rolls.ToList()));
    }



}