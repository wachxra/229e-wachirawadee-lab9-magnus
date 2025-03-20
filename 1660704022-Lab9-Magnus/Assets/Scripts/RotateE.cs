using UnityEngine;

public class RotateE : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV;
    [SerializeField] private Vector3 torque;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}