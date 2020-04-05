using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changedaynight : MonoBehaviour
{
    MeshRenderer meshrenderer;
    public Texture day;
    public Texture night;
    public int tch2 = 0;
    public GameObject light;

    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        meshrenderer.material.SetTexture("_EmissionMap", day);
        meshrenderer.material.SetTexture("_MainTex", day);
        light.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Day() {
        if (tch2 == 2) tch2 = 0;
        if (tch2 == 1)
        {
            meshrenderer.material.SetTexture("_EmissionMap", day);
            meshrenderer.material.SetTexture("_MainTex", day);
            light.SetActive(true);
            tch2++;
        }
 if (tch2 == 0)
        {
            meshrenderer.material.SetTexture("_EmissionMap", night);
            meshrenderer.material.SetTexture("_MainTex", night);
            light.SetActive(false);
            tch2++;
        }
    }
}

        
        