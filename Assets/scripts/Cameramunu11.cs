using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramunu11 : MonoBehaviour
{
    public GameObject walls;
    public GameObject menu1;
    public GameObject menu2;
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
        gameObject.transform.position = new Vector3(-331.7f, 77.732f, -44.4f);
        gameObject.GetComponent<Collider>().enabled = true;


    }

    public void pik()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.transform.position = new Vector3(-117.9119f, 77.471f, 28.20471f);
        gameObject.GetComponent<Collider>().enabled = true;
    }

    public void m50()
    {
       
        walls.transform.position = new Vector3(-332.5533f, 68.39405f, -58.907f);
        menu1.transform.position = new Vector3(-327.9125f, 77.87587f, -50.42f);
        menu2.transform.position = new Vector3(-330.5074f, 78.49133f, -49.58f);


    }
    public void m60()
    {
        
       walls.transform.position = new Vector3(-332.5533f, 68.39405f, -59.758f);
        menu1.transform.position = new Vector3(-327.9125f, 77.87587f, -51.324f);
        menu2.transform.position = new Vector3(-330.5074f, 78.49133f, -50.47f);


    }
}
