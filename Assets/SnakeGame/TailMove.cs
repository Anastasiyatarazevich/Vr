using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMove : MonoBehaviour
{
    public float Speed;

    public float RotationSpeed;

    public Vector3 TailTarget;

    public SnakeMove MainSnake;
    public GameObject tailTargetobj;
    public int num;

    void Start()
    {
        MainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();

        Speed = MainSnake.Speed - 3f;
        tailTargetobj = MainSnake.tailObjects[MainSnake.tailObjects.Count - 2];
        num = MainSnake.tailObjects.IndexOf(gameObject);
    }
    void Update()

    {
        TailTarget = tailTargetobj.transform.position;
        TailTarget.z -= MainSnake.z_offset;
        transform.LookAt(TailTarget);
        transform.position = Vector3.Lerp(transform.position, TailTarget, Time.deltaTime * Speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (num > 4)
            {
              
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
