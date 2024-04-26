using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animale : MonoBehaviour {
    public Animali animaliComponent;

    void Start() {
        if (animaliComponent == null) {
            animaliComponent = gameObject.GetComponentInParent<Animali>();
        }
    }

    void OnCollisionEnter(Collision collision) {
        var thisName = gameObject.name;
        var thatName = collision.gameObject.name;
        if (thisName.StartsWith("Animale") && thatName.StartsWith("Cavaliere")) {
            thisName = thisName["Animale".Length..];
            thatName = thatName["Cavaliere".Length..];
            if (int.TryParse(thisName, out int thisResult) && int.TryParse(thatName, out int thatResult)) {
                animaliComponent.TestCollision(thisResult, thatResult);
            }
        }
    }
}
