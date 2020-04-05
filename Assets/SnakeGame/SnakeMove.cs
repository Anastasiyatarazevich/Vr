using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMove : MonoBehaviour
{
   public float Speed;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float RotationSpeed;
    public float z_offset = 0.7f;
    public GameObject TailPrefab;
public Text txt;
    public int scorre = 0;
    public int numbers = 0;
    public int Max_Score = 0;
   // public GameObject Panel;
    public Text txtMaxScore;
    

   

    void Start()
    {

       
    

        Max_Score = PlayerPrefs.GetInt("MaxScore");

        tailObjects.Add(gameObject);
   }

   
   void Update()
   {
      // scoretxt.text = scorre.ToString();

        txt.text = "Score: " + scorre;
        txtMaxScore.text = "Max Score: " + PlayerPrefs.GetInt("MaxScore"); 
        
        if (Max_Score < scorre)
        {
            Max_Score = scorre;
            PlayerPrefs.SetInt("MaxScore", Max_Score);
            PlayerPrefs.Save();
        }


       



        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

       if (OVRInput.Get(OVRInput.Button.Two))
       {
           transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
       }

       if (OVRInput.Get(OVRInput.Button.One))
       {
           transform.Rotate(Vector3.up*(-1) * RotationSpeed * Time.deltaTime);
       }
   }

   public void AddTail()
   {
      
        scorre++;

       Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
       newTailPos.z -= z_offset;

       tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);

   }
}
