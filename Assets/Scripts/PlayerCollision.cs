// Libraries
using UnityEngine;

// Script class | All script
public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    // When Colliding - Script will run
    void OnCollisionEnter(Collision collisionInfo) 
    {
        // Runs if Collider Tag = Obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
