using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Computer : MonoBehaviour
{

    public GameObject canvas;


   public void ChageScenes()
    {
     //   currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      //  PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
      //  sceneManager.LoadScene(0);
        Application.LoadLevel("Snake");
        canvas.SetActive(false);
    }
    public void Update()
    {
      //  if(Input.GetKeyDown("space"))
      //  Application.LoadLevel ("mainpr");

    }
}
