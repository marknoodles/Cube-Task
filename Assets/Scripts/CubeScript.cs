using TMPro;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public static int movingSpeed;

    public static int moveDistance;

    public static float timeToSpawn;

    [SerializeField]
    TMP_InputField assignCubeSpeed;

    [SerializeField]
    TMP_InputField assignCubeDistance;

    [SerializeField]
    TMP_InputField assignTimeToSpawn;

    public void AssignCubeVariables()
    {
        int.TryParse(assignCubeSpeed.text, out int speedResult);
        int.TryParse(assignCubeDistance.text, out int distanceResult);
        float.TryParse(assignTimeToSpawn.text, out float spawnTimeResult);
        movingSpeed = speedResult;
        moveDistance = distanceResult;
        timeToSpawn = spawnTimeResult;
        TimerScript.timerOn = true;
        TimerScript.timeLeft = timeToSpawn;
        CubeController.movingSpeed = movingSpeed;
        CubeController.cubeDestination = moveDistance;
    }
}
