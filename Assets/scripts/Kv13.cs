using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kv13 : MonoBehaviour
{
    public Color clr1 = new Color(0.169f, 0.169f, 0.169f);
    public Color clr2 = new Color(0.245f, 0.222f, 0.179f);
    public Color clr3 = new Color(0.176f, 0.224f, 0.230f);
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Firstclr()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = clr1;
    }

    public void Secondclr()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = clr2;
    }
    public void Thirdclr()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = clr3;
    }
    
    
    private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Firstclr();

            }
            if (Input.GetButtonDown("Fire2"))
            {
                Secondclr();

            }
           /* if (Input.GetKeyDown("t"))
            {
                Thirdclr();

            }*/
          
        }
}
    

