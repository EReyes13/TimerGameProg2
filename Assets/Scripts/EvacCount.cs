using UnityEngine;
using TMPro;
public class EvacCount : MonoBehaviour
{
    
   public TextMeshProUGUI EvacTimer;
   public float timer = 60;

   public static bool Final = false;

    // Update is called once per frame
    void Update()
    {
        if(Final)
        {
            timer -= Time.deltaTime;
            EvacTimer.text = (("Time:") + timer.ToString("F0") +("seconds"));
        }
    }
}
