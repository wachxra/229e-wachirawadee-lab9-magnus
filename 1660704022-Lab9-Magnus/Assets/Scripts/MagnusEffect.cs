using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private Vector3 velocity, spin;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            ApplyMagnusEffect();
        }
    }

    void Kick()
    {
        rb.linearVelocity = velocity; // straight
        rb.angularVelocity = spin; // spin
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce, ForceMode.Force);
    }
}