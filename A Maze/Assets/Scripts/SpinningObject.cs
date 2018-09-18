using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    public float rotationSpeed = 2f;

    // Can't be too fast or else user will have difficulty on hitting it
    public float movementSpeed = 0.002f;

    void Update()
    {
        // Change between 0 and 1
        var variation = Mathf.Sin(Time.timeSinceLevelLoad);

        // I could use absolute speed here to make it rotate it only one way but I liked the result
        this.transform.Rotate(Vector3.up * (variation * rotationSpeed), Space.World);

        this.transform.Translate(Vector3.up * (variation * movementSpeed), Space.World);
    }

    public void DestroyAfterSeconds(float seconds, GameObject objectToDestroy)
    {
        StartCoroutine(DestroyAfterSecondsCoroutine(seconds, objectToDestroy));
    }

    private IEnumerator DestroyAfterSecondsCoroutine(float seconds, GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(objectToDestroy);
    }
}
