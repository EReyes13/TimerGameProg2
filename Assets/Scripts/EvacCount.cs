using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class EvacCount : MonoBehaviour
{
    
   public TextMeshProUGUI EvacTimer;
   public float timer = 60;

   public static bool Final = false;

    // Update is called once per frame
    void Start()
    {
        Final = false;
        timer = 60;
    }
    void Update()
    {
        if(Final)
        {
            timer -= Time.deltaTime;
            EvacTimer.text = (("Time:") + timer.ToString("F0") +("seconds"));
        }
        if (timer<= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
