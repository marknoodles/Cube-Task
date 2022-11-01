using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public static float timeLeft;

    public static bool timerOn = false;

    [SerializeField]
    TextMeshProUGUI timerTxt;

    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer (timeLeft);
            }
            else
            {
                timeLeft = CubeScript.timeToSpawn;
            }
        }
    }

    private void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
