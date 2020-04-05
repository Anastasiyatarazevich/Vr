using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectRotation : MonoBehaviour
{
    public float dy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dy = gameObject.transform.eulerAngles.y;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Floor" || collision.collider.name == "Floor1" || collision.collider.name == "Floor2")
         {

            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, dy, 0));
        }
    }
}
