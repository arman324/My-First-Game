using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMovement movement;
  public Rigidbody rb;

    void OnCollisionEnter (Collision CollisonInfo){
      if (CollisonInfo.collider.tag == "stone"){
          movement.enabled = false;
          rb.useGravity = true;
      }
    }
}
