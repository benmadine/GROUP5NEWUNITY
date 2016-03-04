using UnityEngine;
using System.Collections;

public class AnimalLifeTime : MonoBehaviour 
{
	//Reginald Life
	float reginaldLife = 5f;
	//Winston Life
	float winstonLife = 5f;
	//Ella Life
	float ellaLife = 5f;
	//Pierre
	float pierreLife = 5f;
	//Roland life
	float rolandLife = 5f;


	// Use this for initialization
	void Start () 
	{
		if (gameObject.tag == "Reginald")
		{
			Destroy(gameObject, reginaldLife);
		}
		if (gameObject.tag == "Winston")
		{
			Destroy(gameObject, winstonLife);
		}
		if (gameObject.tag == "Ella")
		{
			Destroy(gameObject, ellaLife);
		}
		if (gameObject.tag == "Pierre")
		{
			Destroy(gameObject, pierreLife);
		}
		if (gameObject.tag == "Roland")
		{
			Destroy(gameObject, rolandLife);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
