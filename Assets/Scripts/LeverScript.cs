using UnityEngine;

public class LeverScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LeverCollide()
    {
        GameManage.Count +=1;
        Destroy(gameObject);
    }
}
