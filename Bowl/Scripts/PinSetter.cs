using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PinSetter : MonoBehaviour {

    public GameObject pinSet;

    private Animator animator;
    private PinCounter pinCounter;
    
    void Start()
    {
        animator = GameObject.FindObjectOfType<Animator>();
        pinCounter = GameObject.FindObjectOfType<PinCounter>();
    }
    
    
    // Handles color better
    void OnTriggerEnter(Collider collider)
    {
        GameObject thingHit = collider.gameObject;
        
        if (thingHit.GetComponent<Ball>())
        {
            pinCounter.ChangeColor(Color.red);
        }
        
    }

    public void PerformAction(ActionMaster.Action action)
    {
        if (action == ActionMaster.Action.Tidy)
        {
            animator.SetTrigger("tidyTrigger");
            pinCounter.ChangeColor(Color.green);

        }
        else if (action == ActionMaster.Action.EndTurn)
        {
            animator.SetTrigger("resetTrigger");
            pinCounter.Reset();
            pinCounter.ChangeColor(Color.black);
        }
        else if (action == ActionMaster.Action.Reset)
        {
            animator.SetTrigger("resetTrigger");
            pinCounter.Reset();
            pinCounter.ChangeColor(Color.black);
        }
        else if (action == ActionMaster.Action.EndGame)
        {
            throw new UnityException("Don't know how to handle end game yet");
        }
    }
    
    public void RaisePins()
    {
        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
        {
            pin.Raise();   
        }
    }

    public void LowerPins()
    {
        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
        {
            pin.Lower();
        }
    }

    public void RenewPins()
    {
        GameObject newPins = Instantiate(pinSet);
        
        newPins.transform.position += new Vector3(0, 50, 0);
        
    }


}
