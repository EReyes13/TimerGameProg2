using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{

    public static int Count = 0;

   

    void Update()
    {
       
        
        
        if(Count >= 6)
        {
            Debug.Log("Countdown start");
            Count = 0;
        }
    }

  
}
