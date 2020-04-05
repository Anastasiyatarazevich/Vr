using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramenu3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void firstroom()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.transform.position = new Vector3(-306.4f, 77.732f, 231.9f);
        gameObject.GetComponent<Collider>().enabled = true;
    }
}
