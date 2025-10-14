using UnityEngine;

public class GameController : MonoBehaviour
{
    private int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore()
    {
        Score += 1;
        Debug.Log("Score: " + Score);
    }
}
