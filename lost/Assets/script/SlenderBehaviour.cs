﻿using UnityEngine;
using System.Collections;

public class SlenderBehaviour : MonoBehaviour {
	
	private PlayerBehaviour player;
	public float radiusToSpawn=30;
	public float minumusRadius=5;
	private float currentRadieusToSpawn;
	
	public Renderer meshSlender;
	//private bool spwaned;
	
	public float scareFactory=0.01f;
	private float currentScareFactory;
	public float distancePlayer;
	public float distancePlayer_arduino;
	public float distanceToAfect;
	
	public float timeToSpawn;
	private float currentTimeToSpawn;
	
	private GameController gameController;
	
	private ArduinoConnection arduino;
	
	// Use this for initialization
	void Start () {
		
		
		player=FindObjectOfType(typeof(PlayerBehaviour)) as PlayerBehaviour;
		//meshSlender.enabled=false;
		
		//player.SetFeedBackAlpha(0.1f);
		
		gameController=FindObjectOfType(typeof(GameController)) as GameController;
		
		currentScareFactory=scareFactory;
		currentRadieusToSpawn=radiusToSpawn;
		
		arduino=FindObjectOfType(typeof(ArduinoConnection)) as ArduinoConnection;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(player.transform);
		/*
		if(Input.GetKeyDown(KeyCode.P))
		{
			Spawn();
		}*/
		
		
		currentTimeToSpawn += Time.deltaTime;
		if(currentTimeToSpawn> timeToSpawn && gameController.totalObjectivesOk > 0)
		{
			currentTimeToSpawn=0;
			
			Spawn();
		}
		
		
		distancePlayer=Vector3.Distance(transform.position, player.transform.position);
		
		distancePlayer_arduino=Vector3.Distance(transform.position, player.transform.position);
		
		
		
		
		/*
		
		
		
		if(distancePlayer < distanceToAfect && meshSlender.isVisible)
		{
			//dano
			player.scare += currentScareFactory/distancePlayer;
			arduino.sendLightningStrike();
		}
		
		*/
		
		
		/*
		
		if(distancePlayer < 20 || distancePlayer < 10 && meshSlender.isVisible)
		{
			arduino.sendLightningStrike();
			player.scare += currentScareFactory/distancePlayer;
		}
		
		*/
		if(distancePlayer < distanceToAfect && meshSlender.isVisible)
		{
			//dano
			player.scare += currentScareFactory/distancePlayer;
			if(audio.isPlaying == false)
				audio.Play();
		}
		if(distancePlayer_arduino < 20)
		{
			arduino.sendLightningStrike();			
		}   
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		//calculo do dano
		if(gameController.totalObjectivesOk>0)
		{
			//exemplo: radius para spawn 30, 30-(30/5*1)=24 e maior que o minimo de radio para spawm
			currentRadieusToSpawn = radiusToSpawn -(radiusToSpawn/gameController.GetTotalObjective()*gameController.totalObjectivesOk);
			
			if(currentRadieusToSpawn<minumusRadius)
				currentRadieusToSpawn=minumusRadius;
			
			currentScareFactory=scareFactory + (scareFactory/gameController.GetTotalObjective()*gameController.totalObjectivesOk);
		}
			
			
		
	
	}
	
	public void Spawn()
	{
		//meshSlender.enabled=false;
		
		Vector3 positionToGo=player.transform.position;
		
		positionToGo.x += Random.Range(-currentRadieusToSpawn, currentRadieusToSpawn);
		positionToGo.z += Random.Range(-currentRadieusToSpawn, currentRadieusToSpawn);
		
		positionToGo.y=Terrain.activeTerrain.SampleHeight(positionToGo);
		
		transform.position=positionToGo;
		
		//spwaned=true;
	}
	/*
	void OnBecameInvisible()
	{
		if(spwaned)
		{
			meshSlender.enabled=true;
			spwaned=false;
		}
	}*/
		
}
