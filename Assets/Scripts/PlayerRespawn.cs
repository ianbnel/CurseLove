using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;

        rb.linearVelocity = Vector2.zero;
    }
}