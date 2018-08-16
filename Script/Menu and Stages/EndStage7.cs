using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndStage7 : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		SceneManager.LoadScene ("Menu");
	}

}
