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

    public GameObject Exit1;
    public GameObject Exit2;
    public GameObject Exit3;


    void Start()
    {
        
    }
    void Update()
    {
       
        
        
        if(Count >= 3)
        {
            Debug.Log("Countdown start");
            Count = 0;
           Evacuate.SetActive(true);
           EvacTime.SetActive(true);
            Exit1.SetActive(true);
            Exit2.SetActive(true);
            Exit3.SetActive(true);
           EvacCount.Final = true;  
        }
    }

  
}
