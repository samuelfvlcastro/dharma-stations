var Slendy : GameObject;

function Start () {

Slendy.SetActive(false);

}

function OnTriggerEnter () { 

 Slendy.SetActive (true);

}

function OnTriggerExit () 

{ 

 Slendy.SetActive(false);
 Destroy(Slendy); }