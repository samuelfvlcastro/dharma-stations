﻿using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	
	private Ray rayToInteract;
	private RaycastHit hitInteract;
	public float rangeInteract;
	public Renderer feedBackSlender;
	
	public float scare=0;
	public float recoverScare;
	
	public AudioClip walking;
	
	private GameController gameController;
	
	

	// Use this for initialization
	void Start () {
		
		
		gameController=FindObjectOfType(typeof(GameController)) as GameController;
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetKeyDown(KeyCode.E))
			if(Input.GetKeyDown(KeyCode.JoystickButton0))
		//float a = Input.GetAxisRaw("joystick button 0");
		//if(Input.GetButtonDown("joystick button 9"))
		//int i = (int)a;
		//if(Input.GetAxisRaw("joystick button 0"));
		//if(Input.GetMouseButton(0))
		//if(Input.GetButtonDown("joystick button 4"))
		
		{
			rayToInteract=Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));
			
			if(Physics.Raycast(rayToInteract, out hitInteract, rangeInteract))
			{
				if(hitInteract.collider.tag == "InteractObject")
				{
					hitInteract.collider.GetComponent<ObjectiveObjectBehaviour>().Interact();
				}
				
				
			}
		
		}
		
		if(scare>0)
		{
			scare-=recoverScare;
			if(scare<0)
				scare=0;
		}
		
		SetFeedBackAlpha(scare);
		
		
		
		if(scare>=1)
			die();
		
		if(GetComponent<CharacterMotor>().inputMoveDirection != Vector3.zero)
		{
			if(audio.isPlaying == false)
			{
				audio.Play();
			}
		}
	
	}
	
	private void SetFeedBackAlpha(float alpha)
	{
		Color currentAlpha = feedBackSlender.material.color;
		currentAlpha.a=alpha;
		
		feedBackSlender.material.color=currentAlpha;
		
	}
	
	void OnGUI()
	{
		GUI.Box(new Rect(15, 30, 75, 23), "Objectives");
    	GUI.Box(new Rect(100, 30, 50, 23), gameController.GetTotalObjectiveOk().ToString() + "/" + gameController.GetTotalObjective().ToString());
	}
	
		
		private void die()
		{
			Application.LoadLevel("final");
		}
}
