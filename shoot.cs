using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot : MonoBehaviour {
	public int speed=20;
	public Rigidbody bullet;
	public Transform fpoint;
	public Text sword_text;
	private float sword_number=20f;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input .GetKeyDown(KeyCode.E))
		{
			if(sword_number>0)
			{
				Rigidbody clone;
				clone = (Rigidbody)Instantiate(bullet,fpoint.position,fpoint.rotation);
				clone.velocity = transform.TransformDirection(Vector3.forward*speed); 
				sword_number=sword_number-1;
			}
			

			//if(sword_number==0)
			
			
			sword ();
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.collider.tag=="bullet")
		{
			//Debug.Log("Hero is catched");
			sword_number=sword_number+20;
			
		}
	}

	void sword()
	{
		sword_text.GetComponent<Text>().text = "："+sword_number;
	}
}
