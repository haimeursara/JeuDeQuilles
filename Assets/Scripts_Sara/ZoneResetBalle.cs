using UnityEngine;

public class ZoneResetBalle : MonoBehaviour
{
    [SerializeField] private Rigidbody balle;
    [SerializeField] private Transform positionDepart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody == balle)
        {
            balle.linearVelocity = Vector3.zero;
            balle.angularVelocity = Vector3.zero;

            balle.transform.position = positionDepart.position;
            balle.transform.rotation = positionDepart.rotation;
        }
    }
}