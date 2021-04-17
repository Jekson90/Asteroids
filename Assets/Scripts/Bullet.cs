using UnityEngine;


/// <summary>
/// Bullet script
/// Script create new bullet in ship position when mouse click
/// </summary>
public class Bullet : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            Instantiate(bullet, Globals.position.position, Quaternion.identity);
    }
}
