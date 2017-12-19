using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

    void OnTriggerExit(Collider otherCollider)
    {
        GameObject thisPin = otherCollider.gameObject;

        if (thisPin.GetComponent<Pin>())
        {
            DestroyObject(thisPin);
        }
    }
}
