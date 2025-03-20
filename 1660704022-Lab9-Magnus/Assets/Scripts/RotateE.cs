using UnityEngine;

public class RotateE : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV;
    [SerializeField] private float torque = 10;

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
            rb.AddTorque(Vector3.up * torque, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}