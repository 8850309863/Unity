
using UnityEngine;

public class Playermovement : MonoBehaviour
{  public Rigidbody rb;
   
      
     public float forwardForce=1000f;
     public float sidewaysforce=1f;
     public VariableJoystick joystick;
  
   
    // Update is called once per frame
    void FixedUpdate()
    {       
        
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        
        
        Vector3 direction =Vector3.forward*joystick.Vertical + Vector3.right * joystick.Horizontal;
        rb.AddForce(direction *sidewaysforce*Time.deltaTime,ForceMode.VelocityChange);
    
        
    
          if(rb.position.y < -1f)
    {
        FindObjectOfType<GameManager>().EndGame();
    }
    }
}
    