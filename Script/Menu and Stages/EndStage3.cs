using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndStage3 : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		SceneManager.LoadScene ("Level4");

	}
}

