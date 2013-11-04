using UnityEngine;
using System.Collections;

public class ObjectiveObjectBehaviour : MonoBehaviour {
	
	
private GameController gameController;

	// Use this for initialization
	void Start () {
		
		gameController=FindObjectOfType(typeof(GameController)) as GameController;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	
	}
	
	public void Interact()
	{
		gameController.totalObjectivesOk++;
		Destroy(gameObject);
	}
}
