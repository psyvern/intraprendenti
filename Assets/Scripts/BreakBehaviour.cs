using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBehaviour : MonoBehaviour
{
    public float minimumVelocity = 5;
    public AudioSource audioSource;
    public GameObject objectToSpawn;

    bool broken = false;

    public void Start() {
    }

    public void OnCollisionEnter(Collision collision) {
        if (!broken && collision.relativeVelocity.magnitude >= minimumVelocity) {
            BreakObject();
        }
    }

    public void BreakObject() {
        broken = true;
        AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
        if (objectToSpawn != null) {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }
}
