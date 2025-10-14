using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] public bool EraseGround;
    private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EraseGround = false;
        rb = GetComponent<Rigidbody>();
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
