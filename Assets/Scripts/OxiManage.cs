using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class OxiManage: MonoBehaviour
{

    public TextMeshProUGUI OxygenText;
    public float Oxygen = 100;
    public static bool loss = true;

    public void Start()
    {
        
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
    }

    public void LoseOxygen() 
    {

        Oxygen -= Time.deltaTime;
        
        OxygenText.text = (("Oxygen Level: ") + Oxygen.ToString("F1") + ("%"));
    }
    public void GainOxygen() 
    {
        Oxygen += Time.deltaTime;
        OxygenText.text = (("Oxygen Level: ") + Oxygen.ToString("F1") + ("%"));

    }
}
