﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Ball ball;

    private Vector3 offset;

	void Start () {

        offset = transform.position - ball.transform.position;

	}
	
	
	void Update () {
        

        if (ball.transform.position.z <= 1750f)
        {
            transform.position = ball.transform.position + offset;
        }


	}
}
