using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Hero : MonoBehaviour {


  public NavMeshAgent agent;	
  public Animator anim ;
 
  public Transform hp_transform;

  public Slider sd_hp;

  public float HP;
  public GameObject human;

  public bool isgamepause;

  private float hpnumber=100f;

  public Text score_text;
  public Text key_text;

  public Text button_text;
  public Text bullet_text;

  public Text text_lose;

  public  float key_number;

  //private float bullet_number;


  private float destory_enemy_number;

  //让英雄可以进入不同场景
  public static Hero instance;

  public string  scenePassword="1";

  public bool isPlaying=true;
  

	void Start ()
	{
		HP=100;
		isgamepause=false;
		instance =this;
	}

	void Update ()
  	{
		if(Input.GetMouseButtonDown(1))
		{
			Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray ,out hit))
			{
			//hit.point;
			print(hit.point);//输出点击坐标
			agent.SetDestination(hit.point);
			}

			
		}

		anim.SetFloat("Speed",agent.velocity.magnitude);

		lifeControl();
	//ui是屏幕坐标，人物是世界坐标
		hp_transform.transform.position=Camera.main.WorldToScreenPoint(transform.position+Vector3.up*3f);

		OnHPChanged(HP);

	
		
		key();

		if(enemy.instance.enemyIsAlive==false)
		{
			destory_enemy_number=enemy.instance.enemy_count;
		}

		//score();

		
	
  	}

	void OnCollisionEnter(Collision other)
	{
		if(other.collider.tag=="Rockfall")
		{
			Debug.Log("Hero is hurted");
			HP=HP-25;
			
		}

		if (other.collider.tag=="enemy")
		{
			Debug.Log("Hero is catched");
			HP =HP -30;
			
		}
		
		if (other.collider.tag=="key")
		{
			//Debug.Log("Hero is catched");
			key_number=key_number+1;
			Debug.Log(key_number);
			Destroy(other.gameObject);
			
		}
		
		
	}

	

	void OnTriggerStay(Collider collider)
	{
		
		if(collider.tag=="obstacle")
		{
			agent.speed=2f;
		}
		if(collider.tag=="accelerator")
		{
			agent.speed=4f;
		}
		
	}

	void OnTriggerExit(Collider collider)
	{
		
		agent.speed=3.5f;
		
	}

	void lifeControl()
	{
		if(HP<=0)
		{
			Debug.Log("Hero is dead");
			isgamepause=true;
			Time.timeScale=0;
			text_lose.text="YOUR HERO IS FAILED!";
		}
	}
	public void OnHPChanged(float hpnumber)
    {
        hpnumber=HP;
		sd_hp.value=HP;
		
    }

	
	
	void key()
	{
		key_text.GetComponent<Text>().text = "："+key_number+"/3";
	}
	
	public void autoAdd()
	{
		destory_enemy_number=destory_enemy_number+1;
		score_text.text="Score:"+destory_enemy_number*3;

	}
	 public void clickbutton()
	 {
		 isgamepause=!isgamepause;
		 if(isgamepause==false)
		 {
			Time.timeScale=1;
			button_text.text="Pause";
			Debug.Log("game is pause");
		 }
		 if(isgamepause==true)
		 {
			Time.timeScale=0;
			button_text.text="Start";
			Debug.Log("game is start");
		 }

	 }

	 public void EndGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
		
		//UnityEditor.EditorApplication.isPlaying = false;
	   	//Application.Quit();
		Debug.Log("game is over");
	}
	


}