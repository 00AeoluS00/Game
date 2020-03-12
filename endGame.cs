using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour {

public bool isPlaying=true;
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Hero.instance.HP<1)
		{
			isPlaying=false;
		}
		EndGame();
	}

	public void EndGame()
	{
		if(isPlaying==false)
		{
			//UnityEditor.EditorApplication.isPlaying = false;
	   		Application.Quit();
		}

	}

}
