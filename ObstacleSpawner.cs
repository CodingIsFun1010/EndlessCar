using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public Transform[] lanes;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        int laneIndex = Random.Range(0, lanes.Length);
        Instantiate(obstaclePrefab, lanes[laneIndex].position, Quaternion.identity);
    }
}
