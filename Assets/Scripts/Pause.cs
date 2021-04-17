using UnityEngine;

/// <summary>
/// Pause script
/// It takes puause when "Esc" press
/// </summary>
public class Pause : MonoBehaviour
{
    bool pause = false;
    public GameObject panel;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            if (!pause)
            {
                Time.timeScale = 0;
                pause = true;
                panel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pause = false;
                panel.SetActive(false);
            }
    }
}
