using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private float zPosition;
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private Transform pivotSpawn;

    private bool canSpawn = true;


    void OnTriggerEnter(Collider other)
    {
        if (!canSpawn)
        {
            return;
        }

        if (other.CompareTag("Player"))
        {
            canSpawn = false;
            Vector3 spawnPosition = pivotSpawn.position + new Vector3(0f, 0, zPosition);
            Instantiate(groundPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
