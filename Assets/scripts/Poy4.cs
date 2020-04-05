using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poy4 : MonoBehaviour
{
    public GameObject chair;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {





    }
    public void trtitem()
    {
        Instantiate(chair);
        //chair.transform.rotation = Quaternion.Euler(-90.00001f, 0f, 0f);
    }
}