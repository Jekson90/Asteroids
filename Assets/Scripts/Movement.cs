using System;
using UnityEngine;

/// <summary>
/// Movement script
/// Script defines ship movement
/// Tracking mouse motion and buttons press
/// </summary>
public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //change ship position with press buttons
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
            transform.position = new Vector2(transform.position.x + speed* Time.deltaTime, transform.position.y);

        //change ship angle
        transform.rotation = Quaternion.Euler(0,0,Angle());

        //return ship on opposite adge scene when ship move out
        if (transform.position.x > 5.1) transform.position = new Vector2(transform.position.x - 10, transform.position.y);
        if (transform.position.x < -5.1) transform.position = new Vector2(transform.position.x + 10, transform.position.y);
        if (transform.position.y > 5.1) transform.position = new Vector2(transform.position.x, transform.position.y - 10);
        if (transform.position.y < -5.1) transform.position = new Vector2(transform.position.x, transform.position.y + 10);

        //set global ship position
        Globals.position = transform;
    }

    //function returns angle from ship towards mouse
    float Angle()
    {
        //some geometry
        double xShip = transform.position.x + 5;
        double yShip = transform.position.y + 5;
        double xMouse = Input.mousePosition.x / 60;
        double yMouse = Input.mousePosition.y / 60;
        double distanse = Math.Sqrt((xShip-xMouse) * (xShip - xMouse) + (yShip-yMouse) * (yShip - yMouse));
        double angle = Math.Acos((yMouse-yShip) / distanse) * 180 / Math.PI;

        if (xMouse > xShip) return (float)(-angle);

        return (float)angle;
    }
}
