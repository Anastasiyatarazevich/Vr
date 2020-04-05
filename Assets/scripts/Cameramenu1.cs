using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramenu1 : MonoBehaviour
{
    

    // Start is called before the first frame update
    
    public void FirstRoom()
    {
        gameObject.transform.position = new Vector3(-330.7f, 77.958f, -48.13f);
        //Instantiate(preag);
    }

    public void SecondRoom()
    {
        gameObject.transform.position = new Vector3(-323.35f, 77.958f, 82.99f);
    }
    public void ThirdRoom()
    {
        gameObject.transform.position = new Vector3(-307.8f, 77.958f, 231.17f);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            FirstRoom();

        }
        if (Input.GetKeyDown("b"))
        {
            SecondRoom();

        }
        if (Input.GetKeyDown("t"))
        {
            ThirdRoom();

        }
       
    }
}
