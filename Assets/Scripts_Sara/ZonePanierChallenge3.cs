using UnityEngine;

public class ZonePanierChallenge3 : MonoBehaviour
{
    [SerializeField] private Rigidbody[] balles;
    [SerializeField] private Transform positionDepart;

    private GestionScore gestionScore;

    private void Start()
    {
        gestionScore = FindFirstObjectByType<GestionScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (Rigidbody balle in balles)
        {
            if (other.attachedRigidbody == balle)
            {
                gestionScore.AjouterPoint();

                balle.linearVelocity = Vector3.zero;
                balle.angularVelocity = Vector3.zero;

                balle.transform.position = positionDepart.position;
                balle.transform.rotation = positionDepart.rotation;
            }
        }
    }
}