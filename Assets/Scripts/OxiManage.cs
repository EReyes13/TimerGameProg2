using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OxiManage: MonoBehaviour
{

    public TextMeshProUGUI OxygenText;
    public float Oxygen = 100;
    public static bool loss = true;

    public static float OxiVig = 100;


    public void Start()
    {
        Oxygen = 100;
        OxiVig = 100;
    }
    public void Update() 
    {
        if (loss) 
        {
            LoseOxygen();
        }
        else 
        {
            GainOxygen();
        }
        if(OxiVig <= 50)
        {
            VignetteManage.black = true;
        }
        else
        {
            VignetteManage.black = false;
        }
        if (Oxygen<= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    public void LoseOxygen() 
    {

        Oxygen -= Time.deltaTime;
        OxiVig -= Time.deltaTime;
        
        OxygenText.text = (("Oxygen Level: ") + Oxygen.ToString("F1") + ("%"));
    }
    public void GainOxygen() 
    {
        Oxygen += Time.deltaTime;
        OxiVig += Time.deltaTime;
        if(Oxygen >= 100)
        {
            Oxygen = Mathf.Min (100f, Oxygen);
            OxiVig = Mathf.Min (100f, OxiVig);
        }
        OxygenText.text = (("Oxygen Level: ") + Oxygen.ToString("F1") + ("%"));

    }
}
