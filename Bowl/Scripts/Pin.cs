using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public float standingThreshold = 3f;
    public float distanceToRaise = 50f;

    private Rigidbody rigidBody;

    public bool IsStanding()
    {
        Vector3 rotationInEuler = transform.rotation.eulerAngles;

        float tiltInX = Mathf.Abs(270-rotationInEuler.x);
        float tiltInZ = Mathf.Abs(rotationInEuler.z);

        //Debug.LogError(name +" "+ tiltInX +" "+ tiltInZ);

        if (tiltInX < standingThreshold && tiltInZ < standingThreshold)
        {
            return true;
        } else
        {
            return false;
        }
        
    }
    void Awake()
    {
        this.GetComponent<Rigidbody>().solverVelocityIterations = 23;
    }


    private void Update()
    {
        IsStanding();

    }


    public void Raise ()
    {
        if (IsStanding())
        {
            rigidBody = GetComponent<Rigidbody>();
            rigidBody.useGravity = false;

            transform.Translate(new Vector3(0, distanceToRaise, 0), Space.World);
            transform.rotation = Quaternion.Euler(new Vector3(270, 0, 0));
        }
    }
    
    public void Lower()
    {
        rigidBody = GetComponent<Rigidbody>();
        
        transform.Translate(new Vector3(0, -distanceToRaise, 0), Space.World);
        
        rigidBody.useGravity = true;

    }


}
