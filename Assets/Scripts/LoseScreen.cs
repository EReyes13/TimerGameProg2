using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Reset()
    {
        SceneManager.LoadScene("GameplayScene");  
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
