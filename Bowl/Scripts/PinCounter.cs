using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinCounter : MonoBehaviour {

    public Text standingDisplay;

    private GameManager gameManager;
    private bool ballLeftBox = false;
    private float lastChangeTime;
    private int lastSettledCount = 10;
    private int lastStandingCount = -1;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        int scorePins = 10 - CountStanding();

        standingDisplay.text = scorePins.ToString();

        if (ballLeftBox)
        {
            CheckStandingCount();
        }
    }

    public void Reset()
    {
        lastSettledCount = 10;        
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            ballLeftBox = true;
        }

    }
    
    void CheckStandingCount()
    {
        int currentStanding = CountStanding();

        if (currentStanding != lastStandingCount)
        {
            lastChangeTime = Time.time;
            lastStandingCount = currentStanding;
            return;
        }

        float settleTime = 3f;

        if ((Time.time - lastChangeTime) > settleTime)
        {
            PinsHaveSettled();
        }
    }

    void PinsHaveSettled()
    {
        int standing = CountStanding();
        int pinFall = lastSettledCount - standing;
        lastSettledCount = standing;

        gameManager.Bowl(pinFall);
        
        lastStandingCount = -1;
        ballLeftBox = false;
        
    }


    public int CountStanding()
    {
        int standing = 0;

        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
        {
            if (pin.IsStanding())
            {
                standing++;
            }
        }
        return standing;
    }

    public Color ChangeColor (Color color)
    {

        return standingDisplay.color = color;
        
    }



}
