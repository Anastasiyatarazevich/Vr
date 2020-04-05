using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color clr1 = new Color(0.5943396f, 0.5943396f, 0.4401477f);
    public Color clr2 = new Color(0.2117647f, 0.1607843f, 0.1254902f);
    public Color clr3 = new Color(0.8392158f, 0.8392158f, 0.8392158f);
    public Color clr4 = new Color(0.8392158f, 0.8392158f, 1f);
    public Color clr5 = new Color(0f, 0f, 0.128f);
    public Color clr6 = new Color(0.524f, 0.854902f, 0.7254902f);
    public Color clr7 = new Color(1f, 1f, 1f);
    public int touch = 0;
    public Texture fl1;
    public Texture fl2;
    public Texture fl3;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
       


    }

    public void changeclr()
    {
        if (touch == 8)
            touch = 0;

        if (touch == 7)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl3);
            gameObject.GetComponent<MeshRenderer>().material.color = clr7;
            touch++;
        }
        if (touch == 6)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl2);
            gameObject.GetComponent<MeshRenderer>().material.color = clr7;
            touch++;
        }

        if (touch == 5) { gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", fl1);
            gameObject.GetComponent<MeshRenderer>().material.color = clr7;
            touch++;
        }
            
        
        if (touch == 4)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = clr5;
            touch++;
        }
        if (touch == 3)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = clr4;
            touch++;
        }
        if (touch == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = clr3;
            touch++;
        }
        if (touch == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = clr2;
            touch++;
        }
        if (touch == 0)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = clr1;
            touch++;
        }
    }
}
