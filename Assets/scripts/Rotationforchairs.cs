using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationforchairs : MonoBehaviour
{
    public float dy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dy = gameObject.transform.eulerAngles.x;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Floor" || collision.collider.name == "Floor1"  || collision.collider.name == "Floor2")
        {

            gameObject.transform.rotation = Quaternion.Euler(new Vector3(dy, 0, 0));
        }
    }
}
