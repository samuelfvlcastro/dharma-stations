using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public int totalObjectivesOk=0;
	private int totalObjectives;
	

	// Use this for initialization
	void Start () {
		
		ObjectiveObjectBehaviour[] objectives = FindObjectsOfType(typeof(ObjectiveObjectBehaviour)) as ObjectiveObjectBehaviour[];
		totalObjectives=objectives.Length;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
	}
	
	public int GetTotalObjective()
	{
		return totalObjectives;
	}
	public int GetTotalObjectiveOk()
	{
		return totalObjectivesOk;
	}
	
	
}
