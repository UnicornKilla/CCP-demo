using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScene4 : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		SceneManager.LoadScene ("Level5");

	}
}

