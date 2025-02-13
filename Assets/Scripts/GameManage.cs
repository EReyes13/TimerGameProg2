using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManage : MonoBehaviour
{
   public static float Oxygen = 100;

    public static int Count = 0;

   public TextMeshProUGUI OxygenText;
    public bool begin = false;
    // Update is called once per frame

    public void Start()
    {
        begin = true;
    }

    void Update()
    {
        if(begin == true)
        {
            Oxygen -= Time.deltaTime;
        }
    
        OxygenText.text = (("Oxygen Level: ") + Oxygen.ToString("F1") +("%") );
        
        
    }

  
}
