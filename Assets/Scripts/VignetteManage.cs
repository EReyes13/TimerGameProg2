using UnityEngine;

public class VignetteManage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer SR;

    public static bool black = false;

    public static bool blue = false;

    public float strength = 0;

    // Update is called once per frame
    void Start()
    {
        black = false;
        blue = false;
    }
    void Update()
    {
       if(black)
       {
        //strength = (100 - OxiManage.OxiVig);
        SR.color = new Color(0,0,0,strength += (0.02f*Time.deltaTime));
       }
       else if(blue)
       {
        SR.color = new Color(0.03f,0.6f,0.9f,0.15f);
       }
       else
       {
        SR.color = new Color (0,0,0,0);
        strength = 0;
       }
        
       
    }
}
