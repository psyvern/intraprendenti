using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class ColorOutlinePropertyAffordanceReceiver : ColorAffordanceReceiver
{
    public Outline outline;

    protected override void OnAffordanceValueUpdated(Color newValue)
    {
        outline.OutlineColor = newValue;
        base.OnAffordanceValueUpdated(newValue);
    }
}