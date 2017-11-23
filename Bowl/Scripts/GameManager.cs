using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public List<int> bowls = new List<int>();

    private PinSetter pinSetter;
    private Ball ball;

    private void Start()
    {
        

        pinSetter = GameObject.FindObjectOfType<PinSetter>();

        ball = GameObject.FindObjectOfType<Ball>();
    }

    public void Bowl (int pinFall)
    {
        bowls.Add(pinFall);

        ActionMaster.Action nextAction = ActionMaster.NextAction(bowls);

        pinSetter.PerformAction(nextAction);
        ball.Reset();
        
    }
    
    
}
