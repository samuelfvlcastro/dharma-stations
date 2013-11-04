var targeti : Transform;

var moveSpeed : float = 5.0;


var upMaxDistance : float = 10.0;





private var initPosition : Vector3;


private var openDoor : boolean = false;

 


function Start() {


    initPosition = targeti.transform.position;  


}


 


function Update () {


    if (!targeti) {


        return; 


    }


   if (openDoor == true) {


        targeti.position.y = Mathf.Min(upMaxDistance, targeti.position.y+moveSpeed * Time.deltaTime);


    }


    else {


       targeti.position.y = Mathf.Max(initPosition.y, targeti.position.y-moveSpeed * Time.deltaTime);  


   }

}








