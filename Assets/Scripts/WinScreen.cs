using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Win()
    {
        SceneManager.LoadScene("GameplayScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
