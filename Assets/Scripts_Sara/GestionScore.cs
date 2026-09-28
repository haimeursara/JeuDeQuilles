using TMPro;
using UnityEngine;

public class GestionScore : MonoBehaviour
{
    [SerializeField] private TMP_Text texteScore;

    private string nomJoueur;
    private int score = 0;

    private void Start()
    {
        nomJoueur = PlayerPrefs.GetString("NomJoueur", "Joueur");
        AfficherScore();
    }

    public void AjouterPoint()
    {
        score++;
        AfficherScore();
    }

    private void AfficherScore()
    {
        texteScore.text = nomJoueur + " - Score : " + score;
    }
}