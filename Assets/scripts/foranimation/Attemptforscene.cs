using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class Attemptforscene : MonoBehaviour
{
    private int cur;

    private int back;
    public void Loadsc()
    {
        cur = UnitySceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", cur);
        UnitySceneManager.LoadScene(1);
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            back = PlayerPrefs.GetInt("SavedScene");
            UnitySceneManager.LoadScene(back);
        }
    }
}
