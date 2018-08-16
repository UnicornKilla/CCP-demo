using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndStage6 : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		SceneManager.LoadScene ("Level7");
	}
}
