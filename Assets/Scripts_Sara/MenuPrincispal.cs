using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputNomJoueur;

    public void Jouer()
    {
        string nomJoueur = inputNomJoueur.text;

        if (nomJoueur == "")
        {
            nomJoueur = "Joueur";
        }

        PlayerPrefs.SetString("NomJoueur", nomJoueur);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Supermarket");
    }
}