using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBehaviour : MonoBehaviour
{
    public float minimumVelocity = 5;
    public AudioSource audioSource;
    public GameObject objectToSpawn;

    public void Start() {
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude >= minimumVelocity) {
            breakObject();
        }
    }

    void breakObject() {
        AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
        if (objectToSpawn != null) {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }
}
