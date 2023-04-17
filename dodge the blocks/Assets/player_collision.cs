
using UnityEngine;

public class player_collision : MonoBehaviour

{
    public movement movement;
  
   
    void OnCollisionEnter(Collision collisionInfo)
    {
        
                if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            
            FindObjectOfType<GameManager>().Endgame();
        }
    }
   
}
