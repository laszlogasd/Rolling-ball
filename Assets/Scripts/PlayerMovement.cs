using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public Rigidbody rig;
    public float jumpHeigh;
    public bool midAir;

	// Update is called once per frame
	void Update ()
    {
        rig.AddForce(new Vector3(-Input.GetAxis("Horizontal"), 0, 0) * speed);

        if (Input.GetButton("Jump") && !midAir)
        {
            rig.AddForce(0, jumpHeigh, 0);
            midAir = true;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            midAir = false;
        }
    }

}
