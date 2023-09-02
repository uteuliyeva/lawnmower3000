using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int nHits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
        {
            nHits++;
            Debug.Log("You've bumped into obstacles this many times: " + nHits);
        }
    }
}
