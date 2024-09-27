using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;
    public float spawnRange = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 randomPosition = GetRandomPosition();
            SpawnTower(randomPosition);
        }
    }
    Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randomX, 0f, randomZ);
    }
    void SpawnTower(Vector3 position)
    {
        GameObject newTower = Instantiate(towerPrefab, position, Quaternion.identity);
        newTower.GetComponent<Tower>().RandomizeScale();
    }
}
