using UnityEngine;

public class DieSpace : MonoBehaviour {

	public GameObject respawn;

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") 
		{
			other.transform.position = respawn.transform.position;
		}
	}


}
