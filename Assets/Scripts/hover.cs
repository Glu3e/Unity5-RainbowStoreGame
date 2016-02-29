using UnityEngine;
using UnityEngine.EventSystems; 
using UnityEngine.UI;

public class hover : MonoBehaviour
{
	public GameObject panel;
	private GameObject Carrot;
	void Start()
	{


	}

	void update()
	{
		
	}

	void OnMouseOver()
	{
		
		Debug.Log ("you are over the object");

		panel.gameObject.SetActive (true);
	}

	void OnMouseExit ()
	{
		panel.gameObject.SetActive (false);
	}
		
}