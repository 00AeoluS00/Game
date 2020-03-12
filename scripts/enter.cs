using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter : MonoBehaviour {

	public string enterpassword;

	private void Start()
	{
		if(Hero.instance.scenePassword==enterpassword)
		{
			Debug.Log("enter");
		}
		else
		{
			Debug.Log("You have not have enough keys!");
		}
	}

	
}
