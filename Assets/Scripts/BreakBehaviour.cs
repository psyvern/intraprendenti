using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBehaviour : MonoBehaviour
{
    public float minimumVelocity = 5;

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude >= minimumVelocity) {
            breakObject();
        }
    }

    void breakObject() {
        Destroy(gameObject);
    }
}
