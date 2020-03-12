using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour {

public Animator lever_anim;
public  static Lever instance;
public Text text_donthave;

public bool lever_bool;
	
	
	void Start () 
	{
		instance=this;
		lever_bool=false;

	}
	
	
	void Update () 
	{	
		lever_anim.SetBool("lever_bool",lever_bool);	

	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag=="Hero")
		{
			if(Hero.instance.key_number==3)
			{
				text_donthave.text="Get you chest!";
				lever_bool=true;
			}
			else
			{
				text_donthave.text="Dont have enough keys!";
			}

			//lever_bool=true;
		}
		Debug.Log(lever_bool);
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag=="Hero")
		{
			lever_bool=false;
			text_donthave.text="";
		}
		//Debug.Log(lever_bool);
	}

	
}
