using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float Force = 1000f;
    public float RotationForce = 10000f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.left * Force * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rigidbody.AddRelativeTorque(Vector3.forward * RotationForce * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rigidbody.AddRelativeTorque(Vector3.back * RotationForce * Time.deltaTime);
        }
    }
}
