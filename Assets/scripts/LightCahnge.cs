using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCahnge : MonoBehaviour
{
    public int touch = 0;
    public int touch2 = 0;
    public int touch3 = 0;
    public int touch4 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ygyg()
    {
        if (touch == 2)
        {
            
            touch=0;
        }

        if (touch == 1)
        {
            gameObject.GetComponent<Light>().enabled = true;
            touch ++;
        }

        if (touch == 0)
        {
            gameObject.GetComponent<Light>().enabled = false;
            touch++;
        }
    }
    
    public void ygyg2()
    {
        if (touch2 == 2)
        {

            touch2 = 0;
        }

        if (touch2 == 1)
        {
            gameObject.GetComponent<Light>().enabled = true;
            touch2++;
        }

        if (touch2 == 0)
        {
            gameObject.GetComponent<Light>().enabled = false;
            touch2++;
        }
    }
    public void ygyg3()
    {
        if (touch3 == 2)
        {

            touch3 = 0;
        }

        if (touch3 == 1)
        {
            gameObject.GetComponent<Light>().enabled = true;
            touch3++;
        }

        if (touch3 == 0)
        {
            gameObject.GetComponent<Light>().enabled = false;
            touch3++;
        }
    }
    public void ygyg4()
    {
        if (touch4 == 2)
        {

            touch4 = 0;
        }

        if (touch4 == 1)
        {
            gameObject.GetComponent<Light>().enabled = true;
            touch4++;
        }

        if (touch4 == 0)
        {
            gameObject.GetComponent<Light>().enabled = false;
            touch4++;
        }
    }
}
