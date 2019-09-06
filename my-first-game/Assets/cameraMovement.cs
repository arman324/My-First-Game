using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 secondOffset;
    public char key = 'b';
    void Update()
    {

      if (Input.GetKey("b") || key == 'b'){
                key = 'b';
        transform.position = player.position + offset;
      }
      if (Input.GetKey("v") || key == 'v'){
        key = 'v';
          transform.position = player.position + secondOffset;
      }

    }
}
