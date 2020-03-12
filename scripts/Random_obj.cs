using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_obj : MonoBehaviour {


public float x_left;
public float y_left;
public float z_left;
public float x_right;
public float y_right;
public float z_right;
public GameObject obj;
	void Start ()
	{
		CreatObj();
		
		InvokeRepeating("CreatObj",1f,1f);
		
	
	}
	

	void Update () 
	{
		if (IsInvoking())
		//Debug.Log("正在生成石头");
		if (Time.fixedTime>100f)
		CancelInvoke("CreatObj");
	}

	void CreatObj()
	{
		for (int i = 0; i < 3; i++) 
 			{
			 Instantiate(obj, new Vector3(Random.Range(x_left,x_right),Random.Range(y_left,y_right),Random.Range(z_left,z_right)), Quaternion.identity);
			}
	}
}
