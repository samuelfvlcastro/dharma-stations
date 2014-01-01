using UnityEngine;
using System.Collections;

public class NewTextScript : MonoBehaviour {
	
	private GameController gameController;

	// Use this for initialization
	void Start () {
		
		gameController=FindObjectOfType(typeof(GameController)) as GameController;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	guiText.text = "" + gameController.GetTotalObjectiveOk() + "" + gameController.GetTotalObjective();
		
	}
}
