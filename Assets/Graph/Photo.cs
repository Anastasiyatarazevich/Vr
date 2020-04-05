using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Photo : MonoBehaviour
{
    public GameObject camera;
    public GameObject roof;
    public GameObject maincamera;
    public Camera captureCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* public void MakeScreenShot()
     {
         camera.SetActive(true);
         maincamera.SetActive(false);
         ScreenCapture.CaptureScreenshot("Planirovka.png");
         camera.SetActive(false);
         maincamera.SetActive(true);
     }*/

    public void MakeScrenshot()
    {
        roof.SetActive(false);

        int width = this.captureCamera.pixelWidth;
        int height = this.captureCamera.pixelHeight;
        Texture2D texture = new Texture2D(width, height);

        RenderTexture targetTexture = RenderTexture.GetTemporary(width, height);

        this.captureCamera.targetTexture = targetTexture;
        this.captureCamera.Render();


 
        RenderTexture.active = targetTexture;
 Rect rect = new Rect(0, 0, width, height);
        texture.ReadPixels(rect, 0, 0);
   texture.Apply();
        byte[] bytes =texture.EncodeToPNG();
        

      
        string filename = "Plan.png";
        System.IO.File.WriteAllBytes(filename, bytes);



        
      
     
    }
}
