using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// Final score script
/// Script takes score value from global varialble
/// It's need to final screen
/// </summary>
public class FinalScore : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = "YOUR SCORE " + Globals.score;
    }
}
