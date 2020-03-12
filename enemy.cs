using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class enemy : MonoBehaviour {

	public NavMeshAgent guardian;
	public Transform hero;

	public Slider sd_hp;

	public Transform hp;

	//public Text score;

    public float HP;
	private float hpnumber=3f;

	public int enemy_count=1;

	public bool isattack=false;

	public static enemy instance;

	public bool enemyIsAlive=true;
	void Start ()
	{
		instance=this;
		
	}
	
	
	void Update () 
	{
		
		if(isattack==true)
		{
			guardian.SetDestination(hero.position);
		}
		
		lifeControl();

		OnHPChanged(HP);
		
		//hp.transform.position=Camera.main.WorldToScreenPoint(transform.position+Vector3.up*2);

		this.guardian.speed=1;
	}

	void OnTriggerEnter(Collider collider)
	{
		
		if(collider.tag=="bullet")
		{
			HP=HP-1f;
		}
		
		
	}

	void OnTriggerStay(Collider collider)
	{
		
		if(collider.tag=="obstacle")
		{
			this.guardian.speed=0.8f;
		}

		if(collider.tag=="Hero")
		{
			isattack=true;
		}
		
		
	}

	void OnTriggerExit(Collider collider)
	{
		
		this.guardian.speed=1f;
		
	}

	void lifeControl()
	{
		if(HP<=0)
		{
			Debug.Log("enemy is dead");
			enemyIsAlive=false;

		  	Hero.instance.autoAdd();
			Destroy(this.gameObject);
			//score.text = "分数：" + ++enemy_count;
			
		}
	}
	public void OnHPChanged(float hpnumber)
    {
        hpnumber=HP;
		sd_hp.value=HP;
	

    }
}
