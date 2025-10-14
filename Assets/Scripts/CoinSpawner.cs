using UnityEngine;

public class CoinSpawner : MonoBehaviour
{   
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private Vector3 spawnArea = new Vector3(8f, 0f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
