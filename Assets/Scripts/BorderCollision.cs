using UnityEngine;

/// <summary>
/// Border collision script
/// Script kills all what contacts with borders behind the scene 
/// It kills wasted objects
/// </summary>
public class BorderCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
       Destroy(collision.gameObject);
    }
}
