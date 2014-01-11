using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
	
	private Ray rayToInteract;
	private RaycastHit hitInteract;
	public float rangeInteract;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.E))
		{
			rayToInteract=Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));
			
			if(Physics.Raycast(rayToInteract, out hitInteract, rangeInteract))
			{
				if(hitInteract.collider.tag == "menuplay")
				{					
					hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().comeca_jogo();
					
					//hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().Interact();
				}
				if(hitInteract.collider.tag == "menuexit")
				{
					
					hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().acaba_jogo();
					
					//hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().Interact();
				}
				if(hitInteract.collider.tag == "menu")
				{
					
					hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().menu_jogo();
					
					//hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().Interact();
				}
			}
		
		}
	
	}
	
	
	
}
