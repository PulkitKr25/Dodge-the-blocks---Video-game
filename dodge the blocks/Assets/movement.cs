
using UnityEngine;

public class movement : MonoBehaviour{
public Rigidbody rb ;
public float forwardforce = 2000f;
public float sidewayforce = 500f;


    
    void Start()
    {
     
    }

    // multiplied with Time.deltaTime so that players with better pc dont get the advantage.
    void FixedUpdate(){
        
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
        

    if (Input.GetKey("d"))
    {
        rb.AddForce(sidewayforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    
        if( Input.GetKey("a"))
    {
        rb.AddForce(-sidewayforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    
        if(rb.position.y < 20f)
    {
        FindObjectOfType<GameManager>().Endgame();
    }
    
}
}