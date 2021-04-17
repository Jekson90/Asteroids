using UnityEngine;

/// <summary>
/// New meteors script
/// Algorithm generates new meteor time
/// </summary>
public class NewMeteors : MonoBehaviour
{
    //begin and end time interval behind meteors
    float firstSmallTimeInterval;
    float lastSmallTimeInterval;
    float firstMiddleTimeInterval;
    float lastMiddleTimeInterval;
    float firstLargeTimeInterval;
    float lastLargeTimeInterval;

    public GameObject largeMeteor;
    public GameObject middleMeteor;
    public GameObject smallMeteor;

    void Update()
    {
        lastSmallTimeInterval = Time.time;
        lastMiddleTimeInterval = lastSmallTimeInterval;
        lastLargeTimeInterval = lastSmallTimeInterval;

        //it's score dependense
        double division = Globals.score;
        if (division < 150) division = 151;

        //small meteors generates faster
        if (lastSmallTimeInterval - firstSmallTimeInterval > 300 / division)
        {
            firstSmallTimeInterval = lastSmallTimeInterval;
            Instantiate(smallMeteor);
            return;
        }

        if (lastMiddleTimeInterval - firstMiddleTimeInterval > 600 / division)
        {
            firstMiddleTimeInterval = lastMiddleTimeInterval;
            Instantiate(middleMeteor);
            return;
        }

        if (lastLargeTimeInterval - firstLargeTimeInterval > 1000 / division)
        {
            firstLargeTimeInterval = lastLargeTimeInterval;
            Instantiate(largeMeteor);
            return;
        }
    }
}
