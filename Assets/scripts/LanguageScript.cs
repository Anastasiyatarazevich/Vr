using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageScript : MonoBehaviour
{
    public int tch = 0;
    public GameObject rus;
    public GameObject eng;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void huh()
    {
        if (tch == 2) tch = 0;
        if (tch == 1)
        {
            eng.SetActive(true);
            rus.SetActive(false);
            tch++;
        }
        if (tch == 0)
        {
            rus.SetActive(true);
            eng.SetActive(false);
            tch++;

        }
    }
}
