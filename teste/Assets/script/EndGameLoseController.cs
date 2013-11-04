using UnityEngine;
using System.Collections;

public class EndGameLoseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUILayout.BeginArea(new Rect(Screen.width/2-60, 150, 120, Screen.height));
			if(GUILayout.Button("Try Again")) Application.LoadLevel("cena");
			if(GUILayout.Button("Exit to Menu"))
		{
			Application.LoadLevel("menu");
		}
			GUILayout.EndArea();
	}
}
