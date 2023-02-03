using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement player;
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            player.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
