using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurFood : MonoBehaviour
{
    public float WidthSize = 23f;
    public float HeightSize = 23f;
    public GameObject food;
    public GameObject curFood;
    public Vector3 curPos;


   void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(food, curPos, Quaternion.identity) as GameObject;
    }
    void RandomPos()
    {
        curPos = new Vector3(Random.Range(491.67f, 469.45f), 1.859665e-06f, Random.Range(526.35f, 504.1f));
    }

    private void Update()
    {
        if (!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
