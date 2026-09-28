using UnityEngine;

public class CanneChallenge2 : MonoBehaviour
{
    [SerializeField] private GameObject visual;

    private Vector3 positionDepart;
    private Vector3 rotationDepart;
    private Rigidbody rb;
    private GestionScore gestionScore;

    public bool estTombee = false;

    private void Start()
    {
        positionDepart = transform.position;
        rotationDepart = transform.eulerAngles;

        rb = GetComponent<Rigidbody>();
        gestionScore = FindFirstObjectByType<GestionScore>();
    }

    private void Update()
    {
        if (!estTombee && Vector3.Dot(transform.up, Vector3.up) < 0.6f)
        {
            estTombee = true;

            gestionScore.AjouterPoint();

            visual.SetActive(false);
        }
    }

    public void Replacer()
    {
        estTombee = false;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.position = positionDepart;
        transform.eulerAngles = rotationDepart;

        visual.SetActive(true);
    }
}