using UnityEngine;

public class GestionQuilles : MonoBehaviour
{
    [SerializeField] private Quille[] quilles;

    public void ReplacerToutesLesQuilles()
    {
        Debug.Log("Reset des quilles"); // verifier que les quilles sont reset"é"

        foreach (Quille quille in quilles)
        {
            quille.Replacer();
        }
    }
}