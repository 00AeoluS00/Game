using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class exit : MonoBehaviour {

	public string sceneName;

	[SerializeField]private string newScenePassword;
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Hero")
		{
			SceneManager.LoadScene("Scene2");	
			Hero.instance.scenePassword=newScenePassword;
		}

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
