using UnityEngine;
using System.Collections;

public enum Menus{
	MainMenu,
	Credits
}

public class MainMenuController : MonoBehaviour {
	
	public Menus currentMenu = Menus.MainMenu;
	
	public string textCredits;
	
	public GUISkin guiSkinToUse;
	
	

	// Use this for initialization
	void Start () {
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		GUI.skin=guiSkinToUse;
		MenusGame();
	}
	
	void MenusGame()
	{
		switch(currentMenu)
		{
		case Menus.MainMenu:
			{
			GUILayout.BeginArea(new Rect(Screen.width/2-60, 150, 120, Screen.height));
			if(GUILayout.Button("Play")) Application.LoadLevel("cena");
			if(GUILayout.Button("Credits")) currentMenu=Menus.Credits;
			if(GUILayout.Button("Exit")) Application.Quit();
			
			GUILayout.EndArea();
			}
			break;
			
		case Menus.Credits:
			{
			GUILayout.BeginArea(new Rect(Screen.width/2-150, 150, 300, Screen.height));
			GUILayout.TextArea(textCredits);
			if(GUILayout.Button("Back")) currentMenu=Menus.MainMenu;
			
			GUILayout.EndArea();
			}
			break;
			
		}
	}
		
}
