using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRightToLeft : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
     [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField]
    float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] 
    float maxTimeBetweenSpawns = 5f;
    // Start is called before the first frame update
    Vector3 speed = new Vector3(-2f, 0, 0);
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
           // Debug.Log("creating");
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(speed);
        }
    }
}
