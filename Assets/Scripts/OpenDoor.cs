using UnityEngine;
using System.Collections;
public class RotateObject : MonoBehaviour
{
    public float targetRotationAngle = 90f;
    public float rotationSpeed = 50f;
    public float animationDuration = 1.0f;
    private bool isAnimating = false;
    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.rotation;
    }

    public void Open()
    {   
        if (!isAnimating)
        {
            targetRotationAngle *=-1;
            StartCoroutine(AnimateRotation(initialRotation, initialRotation * Quaternion.Euler(0, targetRotationAngle, 0), animationDuration));
        }
    }

    IEnumerator AnimateRotation(Quaternion startRotation, Quaternion endRotation, float duration)
    {
        isAnimating = true;

        float elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);

            elapsedTime += Time.deltaTime;
            
            yield return null;
        }

        transform.rotation = endRotation;
        initialRotation = transform.rotation;
        isAnimating = false;
    }
}