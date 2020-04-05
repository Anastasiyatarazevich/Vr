
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koordinates : MonoBehaviour
{

    public Transform Dectination;
    public float timer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 4)
        {
            gameObject.transform.position = Dectination.position;

            timer = 0;

        }

    }

}
