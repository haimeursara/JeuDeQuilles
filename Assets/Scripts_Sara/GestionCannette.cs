using UnityEngine;

public class GestionCannette : MonoBehaviour
{
    [SerializeField] private CanneChallenge2[] canettes;

    private void Update()
    {
        bool toutesTombees = true;

        foreach (CanneChallenge2 canette in canettes)
        {
            if (!canette.estTombee)
            {
                toutesTombees = false;
            }
        }

        if (toutesTombees)
        {
            ReplacerToutesLesCanettes();
        }
    }

    public void ReplacerToutesLesCanettes()
    {
        foreach (CanneChallenge2 canette in canettes)
        {
            canette.Replacer();
        }
    }
}