using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreakBehaviour : MonoBehaviour
{
    public float minimumVelocity = 5;
    public AudioSource audioSource;
    public UnityEvent action;

    bool broken = false;

    public void Start() {
        broken = false;
    }

    public void OnCollisionEnter(Collision collision) {
        if (!broken && collision.relativeVelocity.magnitude >= minimumVelocity) {
            BreakObject();
        }
    }

    public void BreakObject() {
        broken = true;
        AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
        action.Invoke();

        Destroy(gameObject);
    }
}
