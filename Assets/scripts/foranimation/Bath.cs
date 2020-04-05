using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bath : MonoBehaviour
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
            animator.Play("livingpos");
            animator.Play("bathshpos");
            animator.Play("New Animation2");
            animator.Play("kitchenshpos");
        }
        if (touch1 == 1)
        {
            animator.Play("bedroom");
            animator.Play("livingroom");
            animator.Play("bathsh");
            animator.Play("New Animation1");
            animator.Play("kitchensh");
            touch1 = 0;
        }
    }
}
