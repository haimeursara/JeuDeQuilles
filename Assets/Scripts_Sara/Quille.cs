using UnityEngine;

public class Quille : MonoBehaviour
{
    private Vector3 positionDepart;
    private Vector3 rotationDepart;
    private Rigidbody rb;

    private void Start()
    {
        positionDepart = transform.position;
        rotationDepart = transform.eulerAngles;

        rb = GetComponent<Rigidbody>();
    }

    public void Replacer()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.position = positionDepart;
        transform.eulerAngles = rotationDepart;
    }
}