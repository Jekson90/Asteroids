using UnityEngine;

/// <summary>
/// Bullet move script
/// Script takes bullet move when it created
/// </summary>
public class BulletMove : MonoBehaviour
{
    public Transform bullet;
    Vector2 direction;
    float speed;
    public Rigidbody2D rb;

    //instantiate direction behind current ship location and mouse location
    private void Start()
    {
        direction = new Vector2(Input.mousePosition.x/30 - 10 - bullet.localPosition.x*2, Input.mousePosition.y / 30 - 10 - bullet.localPosition.y*2);
        speed = 15;
    }

    void Update()
    {
        rb.velocity = direction.normalized * speed;        
    }
}
