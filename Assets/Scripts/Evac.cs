using UnityEngine;
using UnityEngine.SceneManagement;
public class Evac : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
