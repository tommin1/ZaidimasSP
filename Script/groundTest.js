#pragma strict

function OnTriggerEnter(other : Collider)
	{
		if (other.gameObject.tag == "Player"){
			gameObject.GetComponent.<Collider>().isTrigger = false;
			yield WaitForSeconds(3);
			gameObject.GetComponent.<Collider>().isTrigger = true;
			other.gameObject.transform.position = Vector3(-270,125,0);
			other.gameObject.GetComponent.<Rigidbody>().isKinematic = true;
		}
	}