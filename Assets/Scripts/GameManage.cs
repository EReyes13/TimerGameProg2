using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{

    public static int Count = 0;
    public TextMeshProUGUI Evac;
    public GameObject Evacuate;
    public GameObject EvacTime;
    
   

    void Update()
    {
       
        
        
        if(Count >= 6)
        {
            Debug.Log("Countdown start");
            Count = 0;
           Evacuate.SetActive(true);
           EvacTime.SetActive(true);
           EvacCount.Final = true;  
        }
    }

  
}
