using UnityEngine;

public class GenerateGround : MonoBehaviour
{

    [SerializeField] private GameObject[] groundPrefabs;
    [SerializeField] private GameObject spawnOrigin;

    void CreateGround()
    {
        int index = Random.Range(0, groundPrefabs.Length);
        Instantiate(groundPrefabs[0], spawnOrigin.transform.position, Quaternion.identity);
    }

    void OnTriggerEnter(Collider other)
    {
        return;
        Debug.Log("Trigger Entered");
        CreateGround();
    }
}
