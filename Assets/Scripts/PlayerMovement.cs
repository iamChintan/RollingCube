using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SideWayForce = 500f;
  
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
