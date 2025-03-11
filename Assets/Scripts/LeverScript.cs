using UnityEngine;

public class LeverScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer SR;
    public BoxCollider2D Box;
    public Sprite V2;
    public void LeverCollide()
    {
        GameManage.Count++;
        SR.sprite = V2;
        GetComponent<BoxCollider2D>().enabled = false;
        //Destroy(gameObject);
    }
}
