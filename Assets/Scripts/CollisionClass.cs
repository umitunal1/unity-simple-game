using UnityEngine;

public class CollisionClass : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("Collided ! -10 health");
        if (coll.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
