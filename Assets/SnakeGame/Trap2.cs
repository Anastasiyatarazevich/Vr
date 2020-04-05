using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2 : MonoBehaviour
{
    public float WidthSize = 23f;
    public float HeightSize = 23f;
    public GameObject trap2;
    public GameObject curTrap2;
    public Vector3 curPos2;


    void AddNewTrap2()
    {
        RandomPos();
        curTrap2 = GameObject.Instantiate(trap2, curPos2, Quaternion.identity) as GameObject;
    }
    void RandomPos()
    {
        curPos2 = new Vector3(Random.Range(491.67f, 479.53f), 1.859665e-06f, Random.Range(526.35f, 504.1f));
    }

    private void Update()
    {
        if (!curTrap2)
        {
            AddNewTrap2();
        }
        else
        {
            return;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {

            Destroy(gameObject);

        }
    }

}
