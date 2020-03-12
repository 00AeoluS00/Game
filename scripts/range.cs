using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class range : MonoBehaviour {


	void Start () 
	{
		
	}
	

	void Update ()
	{
		
	}

	void OnTriggerStay(Collider collider)
	{
		if(collider .tag=="Hero")
		{
			enemy.instance.isattack=true;
		}
	}
}
