using UnityEngine;
using System.Collections;

public class gravity1 : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

    void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
      
        Vector3 movement = new Vector3(0.0f, -1.0f, 0.0f);
        rb.AddForce(movement * speed);
    }
}


