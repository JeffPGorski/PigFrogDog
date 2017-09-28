using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour 


{
	private GameController gameController;

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Boundary") 
		{
			Destroy(other.gameObject);
		}
	}
}
