using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtonAction : MonoBehaviour
{
    /// <summary>
    /// Permet d'afficher un panel transmis en paramètre
    /// </summary>
    /// <param name="PanelAOuvrir">Panel à afficher</param>
    public void AfficherPanel(GameObject PanelAOuvrir)
    {
        PanelAOuvrir.SetActive(true);
    }

    /// <summary>
    /// Permet de ferme aussi le panel actuel
    /// </summary>
    /// <param name="PanelAFermer">Panel à fermer</param>
    public void FermerPanel(GameObject PanelAFermer)
    {
        PanelAFermer.SetActive(false);
    }

    /// <summary>
    /// Permet de charger un niveau
    /// </summary>
    /// <param name="nom">Nom du niveau à charger</param>
    public void ChargerNiveau(string nom)
    {

        if (nom == "Level2")
        {
            for (int i =0; i<=GameManager.Instance.PlayerData.NiveauAccomplis.Length-1; i++)
            {
                if (GameManager.Instance.PlayerData.NiveauAccomplis[i] == "Niveau1")
                {
                SceneManager.LoadScene("Level2");
                }
                else
                {
                SceneManager.LoadScene("MainMenu");
                }
            }
        }
        else if (nom == "Level3")
        {
            for (int i =0; i<=GameManager.Instance.PlayerData.NiveauAccomplis.Length-1; i++)
            {
                if (GameManager.Instance.PlayerData.NiveauAccomplis[i] == "Niveau2")
                {
                SceneManager.LoadScene("Level3");
                }
                else
                {
                SceneManager.LoadScene("MainMenu");
                }
            }
        }
        else
        {
                SceneManager.LoadScene("Level1");
        }
    }

    /// <summary>
    /// Permet de fermer l'application
    /// </summary>
    public void Quitter()
    {
        Application.Quit();
    }
}
