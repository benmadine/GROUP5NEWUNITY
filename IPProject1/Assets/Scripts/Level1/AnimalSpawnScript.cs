using UnityEngine;
using System.Collections;

public class AnimalSpawnScript : MonoBehaviour {
	//Array of animals
	public GameObject[] animals;
	//Array of spawns
	public Transform[] spawns;
	//Max number of animals
	public int maxAnimals = 4;
	public int currentAnimals;

	void Start ()
	{
		InvokeRepeating("Spawn", Random.Range(1,5), Random.Range(1,5));
	}

	void update()
	{
	}
	
	void Spawn ()
	{
		if (currentAnimals == maxAnimals) 
		{
			return;
			Debug.Log ("AnimalsMax");
		}
		int animalIndex = Random.Range(0, animals.Length);
		int spwanPointIndex = Random.Range(0, spawns.Length);
		//new WaitForSeconds (Random.Range(1, 10));
		Instantiate(animals[animalIndex], spawns[spwanPointIndex].position, spawns[spwanPointIndex].rotation);
		currentAnimals++;
	}
}
