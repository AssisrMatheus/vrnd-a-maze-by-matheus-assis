using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// TODO: Get convenient access the Scene and SceneManager classes
// Use the 'using' keyword to include the SceneManagement namespace

public class SignPost : MonoBehaviour {

	public void ResetScene () {
		/// Called when the 'SignPost' game object is clicked
		/// - Reloads the scene

        SceneManager.LoadScene(0);
	}
}
