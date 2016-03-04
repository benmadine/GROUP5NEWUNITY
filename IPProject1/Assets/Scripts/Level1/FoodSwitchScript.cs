using UnityEngine;
using System.Collections;

public class FoodSwitchScript : MonoBehaviour {

	public GameObject foodObject;
	public Sprite carrotImage;
	public Sprite meatImage;
	public Sprite strawberryImage;
	public Sprite insectImage;
	
	void Start()
	{

	}

	public void CarrotSwitch()
	{
		foodObject.tag = "Carrot";
		foodObject.GetComponent<SpriteRenderer> ().sprite = carrotImage;
	}

	public void MeatSwitch()
	{
		foodObject.tag = "Meat";
		foodObject.GetComponent<SpriteRenderer> ().sprite = meatImage;
	}

	public void StrawBerrySwitch()
	{
		foodObject.tag = "Strawberry";
		foodObject.GetComponent<SpriteRenderer> ().sprite = strawberryImage;
	}

	public void InsectSwitch()
	{
		foodObject.tag = "Insect";
		foodObject.GetComponent<SpriteRenderer> ().sprite = insectImage;
	}
}
