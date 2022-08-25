using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{       
    public Playermovement movement;
       
    

    void OnCollisionEnter(Collision Collisioninfo)
    {

            if(Collisioninfo.collider.tag=="Obstacle")
            {

                    movement.enabled = false;
                    FindObjectOfType<GameManager>().EndGame();
            }
    }
        
  
   
}
