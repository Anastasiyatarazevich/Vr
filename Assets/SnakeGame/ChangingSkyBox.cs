﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingSkyBox : MonoBehaviour
{
    public Material[] materials;

    void Start()
    {
        GetComponent<Skybox>().material = materials[Random.Range(0, materials.Length)];
    }

   
}
