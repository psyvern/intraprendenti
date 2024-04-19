using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBehaviour : MonoBehaviour
{
    public float minimumVelocity = 5;
    public AudioSource audioSource;
    public Renderer rend;

    public void Start(){ 
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude >= minimumVelocity) {
            breakObject();
        }
    }

    void breakObject() {
        audioSource.Play();
        rend.enabled = false;
        Destroy(gameObject, audioSource.clip.length);
        
    }
}
