using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poy : MonoBehaviour
{
    public GameObject sofa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Instantiate(sofa);
            //chair.transform.rotation = Quaternion.Euler(-90.00001f, 0f, 0f);
        }
    }
}