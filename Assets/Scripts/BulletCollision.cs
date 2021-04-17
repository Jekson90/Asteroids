using UnityEngine;

/// <summary>
/// Bullet collision script
/// Script kills meteor, if it contact with bullet
/// </summary>
public class BulletCollision : MonoBehaviour
{    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Middle Meteor(Clone)")
        {
            Destroy(collision.gameObject);
            Globals.score += 10;
        }
        if (collision.gameObject.name == "Small Meteor(Clone)")
        {
            Destroy(collision.gameObject);
            Globals.score += 5;
        }
        if (collision.gameObject.name == "Large Meteor(Clone)")
        {
            Destroy(collision.gameObject);
            Globals.score += 15;
        }
    }
}
