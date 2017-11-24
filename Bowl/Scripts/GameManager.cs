using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public List<int> rolls = new List<int>();

    private PinSetter pinSetter;
    private Ball ball;
    private ScoreDisplay scoreDisplay;

    private void Start()
    {
        scoreDisplay = GameObject.FindObjectOfType<ScoreDisplay>();

        pinSetter = GameObject.FindObjectOfType<PinSetter>();

        ball = GameObject.FindObjectOfType<Ball>();
    }

    public void Bowl (int pinFall)
    {   
            rolls.Add(pinFall);

            ball.Reset();

            pinSetter.PerformAction(ActionMaster.NextAction(rolls));
        try
        {
            scoreDisplay.FillRolls(rolls);
            scoreDisplay.FillFrames(ScoreMaster.ScoreCumulative(rolls));
        } catch
        {
            Debug.LogWarning("Error here - todo Joao");
        }
    }
}
