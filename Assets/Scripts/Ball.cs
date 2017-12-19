using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody rigidBody;
    private AudioSource ballRollSound;
    private Vector3 startPosition;
    private DragLaunch dragLaunch;

    public bool inPlay;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        dragLaunch = GetComponent<DragLaunch>();

        rigidBody.useGravity = false;

        startPosition = transform.position;

        inPlay = true;
    }


    public void Launch (Vector3 velocity)
    {
        rigidBody.useGravity = true;
        rigidBody.velocity = velocity;

        ballRollSound = GetComponent<AudioSource>();
        ballRollSound.Play();
    }

    public void Reset()
    {
        inPlay = false;

        transform.position = startPosition;
        transform.rotation = Quaternion.identity;

        rigidBody.angularVelocity = Vector3.zero;
        rigidBody.velocity = Vector3.zero;
        rigidBody.useGravity = false;

        dragLaunch.isMoving = false;
    }

 
}
