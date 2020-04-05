using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bedroom : MonoBehaviour
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
            animator.Play("livingpos");
            animator.Play("bath");
            animator.Play("bedroomshpos");
            animator.Play("New Animation2");
        }
        if (touch1 == 2)
        {
            animator.Play("livingroom");
            animator.Play("bathpos");
            animator.Play("bedroomsh");
            animator.Play("New Animation1");
            touch1 = 0;
        }
    }
}
