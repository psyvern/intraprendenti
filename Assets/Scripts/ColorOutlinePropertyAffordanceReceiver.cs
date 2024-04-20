using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class ColorOutlinePropertyAffordanceReceiver : ColorAffordanceReceiver
{
    public Outline outline;

    protected override void Start() {
        if (outline == null) outline = GetComponent<Outline>();
    
        base.Start();
    }

    protected override void OnAffordanceValueUpdated(Color newValue) {
        outline.OutlineColor = newValue;

        base.OnAffordanceValueUpdated(newValue);
    }
}