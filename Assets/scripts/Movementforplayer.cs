using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementforplayer : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody rig;
    float hor;
    float ver;
    void Start()
    {
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        rig.AddForce(((transform.right * hor) + (transform.forward * ver)) * speed / Time.deltaTime);

    }
}
