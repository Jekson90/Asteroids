using UnityEngine;

/// <summary>
/// Meteor collision script
/// Script kills bullet when it collides meteor
/// and decreases global health variable when ship collides meteor
/// </summary>
public class MeteorCollision : MonoBehaviour
{
    //kill bullet when it collides meteor
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
            Destroy(collision.gameObject);        
    }

    //decrease global health variable when ship collides meteor
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ship Object(Clone)")
        {
            //reset ship position on center
            collision.gameObject.transform.position = new Vector2(0, 0);

            if (Globals.health > 0)
                Globals.health--;
        }
    }
}
