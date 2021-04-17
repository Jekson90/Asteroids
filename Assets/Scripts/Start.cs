using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// Start script
/// It starts game when pressed "start" or "again" button
/// Start main scene
/// </summary>
public class Start : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
