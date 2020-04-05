using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popo : MonoBehaviour
{
    public GameObject knopka;
    public GameObject u1;
    public GameObject u2;
    public GameObject knopka1;
    public int touch = 0;

    void Start()
    {

    }


    void Update()
    {

    }

    public void perehod()
    {
        knopka.SetActive(true);
        u1.SetActive(false);
        u2.SetActive(false);
        knopka1.SetActive(true);
    }

    public void perehod1()
    {
        knopka.SetActive(false);
        u1.SetActive(true);
        u2.SetActive(true);
        knopka1.SetActive(false);
    }

    public void ch()
    {
        if (touch == 2)
        {
           
            touch=0;

        }

        if (touch == 1)
        {
            perehod1();
            touch ++;

        }

        if (touch == 0)
        {
            perehod();
            touch++;

        }
    }
}
