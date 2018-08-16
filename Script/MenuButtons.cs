using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

	public void StartGame()
	{
		Application.LoadLevel (1);
	}
	public void LevelsGame(){
		Application.LoadLevel (8);
	}
	public void ExitGame()
	{
		Application.Quit();
	}


}
