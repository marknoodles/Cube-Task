using System.Collections;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    private float spawnTime;

    public GameObject objectToSpawn;

    public void WhichObjectToSpawn()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    IEnumerator SpawnCubes()
    {
        spawnTime = CubeScript.timeToSpawn;
        WhichObjectToSpawn();
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            WhichObjectToSpawn();
        }
    }

    public void StartCoroutine()
    {
        StartCoroutine(SpawnCubes());
    }

    public void StopSpawnCoroutine()
    {
        StopAllCoroutines();
    }
}
