// Libraries
using UnityEngine;

// Script class | All script
public class PlayerMovement : MonoBehaviour

{   // Component "Rigidbody" reference "rb"
    public Rigidbody rb;

    // Foward/Sideways force of player | Variables
    public float fowardForce = 8000f;
    public float sidewayForce = 120f;

    // Update is called once per frame
    // FixedUpdate is called once per frame but only used when using physics
    void FixedUpdate()
    {
        // Add foward force ("" * Time.)
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        // Add sideway force
        if (Input.GetKey("d"))
        {
            // Unchangeable | No Variable
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            // Unchangeable | No Variable
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Call End Game when player has fallen
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
