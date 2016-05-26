using UnityEngine;
using System.Collections;

public class Player_sekimas : MonoBehaviour {

    public GameObject plyer;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - plyer.transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = plyer.transform.position + offset;
	}
}
