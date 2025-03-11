using UnityEngine;

public class OxygenScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void breathe()
    {
       
      OxiManage.loss = false;
      VignetteManage.blue = true;
     
    }
    public void Exhale()
    {
      OxiManage.loss = true;
      VignetteManage.blue = false;
    }
}