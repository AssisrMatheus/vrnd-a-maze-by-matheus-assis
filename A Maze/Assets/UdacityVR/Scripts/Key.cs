using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : SpinningObject {

    // Declare a Door named 'door' and assign the top level 'Door' game object to the field in Unity
    public GameObject keyPoofPrefab;
    public Door doorPrefab;

    public void OnKeyClicked () {
        /// Called when the 'Key' game object is clicked
        /// - Unlocks the door (handled by the Door class)
        /// - Displays a poof effect (handled by the 'KeyPoof' prefab)
        /// - Plays an audio clip (handled by the 'KeyPoof' prefab)
        /// - Removes the key from the scene

        if (doorPrefab != null)
        {
            doorPrefab.Unlock();
        }

        if (keyPoofPrefab != null)
        {
            Instantiate(keyPoofPrefab, this.transform.position, keyPoofPrefab.transform.rotation);
        }

        DestroyAfterSeconds(0.02f, this.gameObject);
    }
}

