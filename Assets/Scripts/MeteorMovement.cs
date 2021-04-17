using UnityEngine;

/// <summary>
/// Meteor movement script
/// Script genetates new meteor position out of screen
/// and takes random movement towards screen
/// </summary>
public class MeteorMovement : MonoBehaviour
{
    public Transform m;         //meteor position
    public Rigidbody2D meteor;  //meteor phisics
    float speed = 0.8f;         //some meteor speed

    void Start()
    {
        int x = Random.Range(-5, 6);
        int y = Random.Range(-5, 6);
        meteor.velocity = new Vector2(x,y).normalized * speed;
        m.position = newPosition(x, y);
    }

    //function generates random point between scene and borders behind the scene
    Vector2 newPosition(int x, int y)
    {
        int a = Random.Range(-5, 6);
        if (a < 0)
            return new Vector2(6 * getReverseSign(x), -a * getReverseSign(y));
        else if (a > 0)
            return new Vector2(a * getReverseSign(x), 6 * getReverseSign(y));
        else return new Vector2(6 * getReverseSign(x), 6 * getReverseSign(y));
    }

    //function returns reverse sign of integer
    int getReverseSign(int x)
    { 
        return (x > 0) ? -1 : 1; 
    }
}
