using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurseurSouris : MonoBehaviour {

	// Use this for initialization
	void Update () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
}
