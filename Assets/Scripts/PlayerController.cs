using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;
    public BoxCollider2D Hitbox;
    public float Speed = 5;

    public GameObject Vignette;


    public void Update()
    {
         Vector2 vel = new Vector2(0,0);
       if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }
        
        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;
        
        
    }
        private void OnCollisionEnter2D(Collision2D other)
        {
         LeverScript count = other.gameObject.GetComponent<LeverScript>(); 
         if (count != null)
         {
            count.LeverCollide();
            
         }
            Evac Eve = other.gameObject.GetComponent<Evac>();
            if(Eve != null)
            {
                Eve.Win();
            }
         }
    private void OnTriggerEnter2D(Collider2D other)
    {
       
    }
    private void OnTriggerExit2D(Collider2D other)
    {
         OxygenScript Oxigen = other.gameObject.GetComponent<OxygenScript>();
        if(Oxigen != null)
        {
            Oxigen.Exhale();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
         OxygenScript Oxigen = other.gameObject.GetComponent<OxygenScript>();
        if(Oxigen != null)
        {
            Oxigen.breathe();
        }
    }
    //OntriggerStay2D "enables a function to occur when the object stays within the collider zone."

}
