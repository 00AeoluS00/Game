using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Random_enemy : MonoBehaviour {

public GameObject enmey;
//public NavMeshAgent guardian;

public float x_left;
public float y_left;
public float z_left;
public float x_right;
public float y_right;
public float z_right;

public float enemy_number;
	void Start ()
	{
		CreatEnemy();
		
		InvokeRepeating("CreatEnemy",10f,20f);
		
		
	
	}
	

	void Update () 
	{
		if (IsInvoking())
		//Debug.Log("正在生成石头");
		if (enemy_number>3)
		CancelInvoke("CreatObj");
	}

	void CreatEnemy()
	{
		for (int i = 0; i < 1; i++) 
 			{
				 
			 //Instantiate(enmey, new Vector3(Random.Range(-36f,-37f),Random.Range(0.21f,0.21f),Random.Range(-7.13f,-7.13f)), Quaternion.identity);
			 Instantiate(enmey, new Vector3(Random.Range(x_left,x_right),Random.Range(y_left,y_right),Random.Range(z_left,z_right)), Quaternion.identity);
			
			}
		enemy_number=enemy_number+1;
	}
}
