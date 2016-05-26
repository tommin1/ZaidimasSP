#pragma strict

function OnTriggerEnter(other : Collider)
	{
		if (other.gameObject.tag == "Player"){
			other.gameObject.GetComponent.<Rigidbody>().isKinematic = true;
			yield WaitForSeconds(5);
			Destroy(gameObject);
			other.gameObject.transform.position = Vector3(-270,125,0);
		}
	}
