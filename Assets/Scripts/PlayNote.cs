using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayNote : MonoBehaviour
{
    int position = 0;
    public int[] notes;
    public UnityEvent onComplete;

    public void Play(int note) {
        if (position >= notes.Length) return;
        
        if (notes[position] == note) {
            Debug.Log("Giusto");
            position += 1;

            if (position == notes.Length) {
                onComplete?.Invoke();
            }
        } else {
            Debug.Log("Sbagliato");
            position = 0;
        }
    }
}
