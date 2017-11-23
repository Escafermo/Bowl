using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour {

    private Ball ball;
    private Vector3 posVec, posVecEnd;
    private float timeStart, timeEnd;

    public bool isMoving;

    private void Start()
    {
        ball = GetComponent<Ball>();

        isMoving = false;
    }

    public void MoveStart (float amount)
    {
        if (!isMoving && ball.transform.position.x >= -40 && ball.transform.position.x <= 40)
        {
            ball.transform.Translate(new Vector3(amount, 0, 0));
            
        }   
        
    }


    public void DragStart()
    {
        // Capture time and position of drag start

        timeStart = Time.time;

        posVec = Input.mousePosition;
        
    }

    public void DragEnd()
    {
        // Capture time and position of drag end - launch the ball

        if (!isMoving)
        {
            isMoving = true;

            timeEnd = Time.time;

            posVecEnd = (Input.mousePosition);

            float dragDuration = timeEnd - timeStart;

            float launchSpeedX = (posVecEnd.x - posVec.x) / dragDuration;
            float launchSpeeZ = (posVecEnd.y - posVec.y) / dragDuration;

            Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeeZ);

            ball.Launch(launchVelocity);

        }  
    }
}
