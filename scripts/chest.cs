using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chest : MonoBehaviour {

public Animator chest_anim;

public bool chest_bool;
public bool iswin;

public Text text_win;
//public Text text_donthave;



	void Start () 
	{
		chest_bool=false;
		iswin=false;
	}
	
	
	private void  Update ()
	{

		chest_anim.SetBool("chest_bool",chest_bool);	

		
		if(Lever.instance.lever_bool==true)
		{	
			chest_bool=true;
		}
		/*if(Lever.instance.lever_bool==false)
		{
			chest_bool=false;
		}*/
	}

	void OnTriggerStay(Collider collider)
	{
		if(collider.tag=="Hero"&&chest_bool==true)
		{
			iswin=true;
			text_win.text="VICTORY!";
			Time.timeScale=0;
		}
	}
}
