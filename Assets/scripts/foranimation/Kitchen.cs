using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen : MonoBehaviour
{
    [SerializeField] Animator animator;
    public int touch1 = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ug4u()
    {
        touch1++;

        if (touch1 == 1)
        {
            animator.Play("bedroompos");
            animator.Play("bath");
            animator.Play("kuhnyapos");
            animator.Play("livingpos");
            animator.Play("kitchenshpos");

        }
        if (touch1 == 2)
        {
            animator.Play("livingroom");
            animator.Play("bedroom");
            animator.Play("bathpos");
            animator.Play("kuhnya");
            animator.Play("kitchensh");
            touch1 = 0;
        }
    }
}
