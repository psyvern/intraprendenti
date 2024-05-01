using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBehaviour : MonoBehaviour
{
    public float minimumVelocity = 5;
    public AudioSource audioSource;
    public GameObject objectToSpawn;
    public GameObject parentForObject;

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
        if (objectToSpawn != null) {
            var spawned = Instantiate(objectToSpawn, transform.position, transform.rotation);
            if (parentForObject != null) {
                spawned.transform.parent = parentForObject.transform;
            }
        }

        Destroy(gameObject);
    }
}
