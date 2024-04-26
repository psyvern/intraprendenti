using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Animali : MonoBehaviour {
    public int[] target;
    public UnityEvent onComplete;

    int[] current;

    void Start() {
        current = new int[target.Length];
    }

    public void TestCollision(int animale, int cavaliere) {
        if (animale <= target.Length && animale <= current.Length) {
            Debug.Log((animale, cavaliere));
            current[animale - 1] = cavaliere;
            
            if (target.SequenceEqual(current)) {
                Debug.Log("yee :D");
                if (onComplete != null) {
                    onComplete.Invoke();
                    onComplete = null;
                }
            }
        }
    }
}
