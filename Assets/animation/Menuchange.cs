using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menuchange : MonoBehaviour
{
    public GameObject menu;
    public int tch2 = 0;

    public void change()
    { if (tch2 == 2) tch2 = 0;
        if (tch2 == 1)
        {
            menu.SetActive(false);
            tch2++;
        }
        if (tch2 == 0)
        {
            menu.SetActive(true);
            tch2++;
        }
    }
}
