using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float WidthSize = 23f;
    public float HeightSize = 23f;
    public GameObject trap;
    public GameObject curTrap;
    public Vector3 curPos;


    void AddNewTrap()
    {
        RandomPos();
        curTrap = GameObject.Instantiate(trap, curPos, Quaternion.identity) as GameObject;
    }
    void RandomPos()
    {
        curPos = new Vector3(Random.Range(479.53f, 469.45f), 1.859665e-06f, Random.Range(526.35f, 504.1f));
    }

    private void Update()
    {
        if (!curTrap)
        {
            AddNewTrap();
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
