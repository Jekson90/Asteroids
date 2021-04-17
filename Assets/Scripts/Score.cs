using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// Score script
/// Script updates score value on screen
/// </summary>
public class Score : MonoBehaviour
{
    public Text textScore;

    void Update()
    {
        textScore.text = Globals.score.ToString();
    }
}
