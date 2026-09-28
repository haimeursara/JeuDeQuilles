using UnityEngine;

public class GestionQuilles : MonoBehaviour
{
    [SerializeField] private Quille[] quilles;

    private void Update()
    {
        bool toutesTombees = true;

        foreach (Quille quille in quilles)
        {
            if (!quille.estTombee)
            {
                toutesTombees = false;
            }
        }

        if (toutesTombees)
        {
            ReplacerToutesLesQuilles();
        }
    }

    public void ReplacerToutesLesQuilles()
    {
        foreach (Quille quille in quilles)
        {
            quille.Replacer();
        }
    }
}