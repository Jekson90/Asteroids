using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Global class
/// It contains global variables and health control
/// </summary>
/// <remarks>
/// Variables are using in different scripts
/// Health decreasing with ship-meteor collisions
/// Open final scene
/// </remarks>
public class Globals : MonoBehaviour
{
    public static int score;            //total score (increase with shoot meteor)
    public static int health;           //total health (decrease with meteor collision) 
    public static Transform position;   //ship position

    public GameObject shipHealth1;      //health indicator
    public GameObject shipHealth2;      //health indicator
    public GameObject shipHealth3;      //health indicator

    public GameObject shipObject;       //main ship object
    
    //instantiate variables with new game session
    void Start()
    {
        score = 0;
        health = 3;

        shipHealth1 = Instantiate(shipHealth1);
        shipHealth2 = Instantiate(shipHealth2);
        shipHealth3 = Instantiate(shipHealth3);

        shipObject = Instantiate(shipObject);
        position = shipObject.transform;
    }

    //kill health indicators with decrease health and open final scene
    void Update()
    {
        if (health == 2)
            Destroy(shipHealth3);
        if (health == 1)
            Destroy(shipHealth2);
        if (health == 0)
        {
            Destroy(shipHealth1);
            Destroy(shipObject);
            SceneManager.LoadScene("FinishMenu");
        }
    }
}
