using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionBehavior : MonoBehaviour {
    public GameObject target;
    public UnityEvent action;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject == target) {
            action.Invoke();
        }
    }
}
