using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorofFloor : MonoBehaviour
{
    public GameObject floor;
    public int touch = 0;
    public int touch1 = 0;
    public Texture fl1;
    public Texture fl2;
    public Texture fl3;
    public Texture fl4;
    public Texture fl5;
    public Texture fl6;


    public Texture fl7;
    public Texture fl8;
    public Texture fl9;
    public Texture fl10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void change()
    {
        if (touch == 7)
        {
            touch = 0;
        }

        if (touch == 6)
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl6);
        touch++;

        if (touch == 5)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl5);
            touch++;
        }
        if (touch == 4)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl4);
            touch++;
        }
        if (touch == 3)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl3);
            touch++;
        }
        if (touch == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl2);
            touch++;
        }
        if (touch == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl1);
            touch++;
        }
        if (touch == 0)
        {
            touch++;
        }
    }



    public void change1()
    {
        if (touch1 == 4)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl10);
            touch1 = 0;
        }
        if (touch1 == 3)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl9);
            touch1++;
        }
        if (touch1 == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl7);
            touch1++;
        }
        if (touch1 == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl8);
            touch1++;
        }


        if (touch1 == 0)
        {
            touch1++;
        }
    }
}
