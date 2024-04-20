using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour
{
    int position = 0;
    public int[] notes;

    public void Play(int note) {
        if (position >= notes.Length) return;
        
        if (notes[position] == note) {
            Debug.Log("Giusto");
            position += 1;

            if (position == notes.Length) {
                Debug.Log("yeee");
            }
        } else {
            Debug.Log("Sbagliato");
            position = 0;
        }
    }
}
