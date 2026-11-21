using UnityEngine;

public class ballCollision : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
   private void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.RestartGame();
    }
}
