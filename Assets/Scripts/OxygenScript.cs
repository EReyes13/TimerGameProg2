using UnityEngine;

public class OxygenScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void breathe()
    {
       
       GameManage.Oxygen = 100;
       
        Destroy(gameObject);
       
    }
}