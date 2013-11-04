using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	
	private Ray rayToInteract;
	private RaycastHit hitInteract;
	public float rangeInteract;
	public Renderer feedBackSlender;
	
	public float scare=0;
	public float recoverScare;

	// Use this for initialization
	void Start () {
		
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0))
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
	
	}
	
	private void SetFeedBackAlpha(float alpha)
	{
		Color currentAlpha = feedBackSlender.material.color;
		currentAlpha.a=alpha;
		
		feedBackSlender.material.color=currentAlpha;
		
	}
		
		private void die()
		{
			Application.LoadLevel("fim");
		}
}
