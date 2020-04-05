using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramenu2 : MonoBehaviour
{
    public GameObject walls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void secondroom()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.transform.position = new Vector3(-326.046f, 77.732f, 80.563f);
        gameObject.GetComponent<Collider>().enabled = true;
    }

    public void m72()
    {

        walls.transform.position = new Vector3(-350.394f, 74.38782f, 71.58729f);
       


    }
    public void m60()
    {

        walls.transform.position = new Vector3(-349.1677f, 74.38782f, 71.58729f);
      


    }
}
