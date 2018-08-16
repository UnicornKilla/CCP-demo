using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
	public int LoadedLevel;

	void Start()
	{
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel (LoadedLevel);
		}

	}
}
