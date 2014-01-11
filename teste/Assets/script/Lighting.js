#pragma strict

var minTime= 0.5;
var hold =0.5;
var myLight : Light;

private var lastime = 0;

function Start () {

}

function Update () {

if((Time.time - lastime) > minTime)
if(Random.value > hold)
light.enabled=true;
else
light.enabled=false;
lastime = Time.time;

}