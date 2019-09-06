using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 200f;
    public float forwardForce = 200f;
    void Start()
    {
      rb.useGravity = false;

    }

    void FixedUpdate()
    {
      rb.AddForce(0,0,forwardForce*Time.deltaTime,ForceMode.VelocityChange);

      if(Input.GetKey("d")){
        rb.AddForce(speed*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }
      if(Input.GetKey("a")){
        rb.AddForce(-speed*Time.deltaTime,0,0,ForceMode.VelocityChange);

      }
      if(Input.GetKey("w")){
        rb.AddForce(0,speed*Time.deltaTime,0,ForceMode.VelocityChange);

      }
      if(Input.GetKey("s")){
        rb.AddForce(0,-speed*Time.deltaTime,0,ForceMode.VelocityChange);

      }
    }
}
