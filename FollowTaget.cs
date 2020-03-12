using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTaget : MonoBehaviour {

	public Transform hero;
	
	private Vector3 offset;
	void Start () 
	{
		offset=transform.position-hero.position;
	}
	
	
	void Update ()
	{
		transform.position=hero.position+offset;
	}
}
