using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDeNiveau : MonoBehaviour
{
    private async void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Félicitation, le niveau est terminé.");

            string niveauTermine = this.transform.tag;

            for (int i =0; i<=GameManager.Instance.PlayerData.NiveauAccomplis.Length-1; i++)
            {
                if (GameManager.Instance.PlayerData.NiveauAccomplis[i] == niveauTermine)
                {
                Debug.Log("Félicitation, le niveau est terminé.");
                }
                else
                {
                GameManager.Instance
                .PlayerData.niveauTermine(niveauTermine);
                }
            }

            GameManager.Instance.SaveData();

            if (niveauTermine == "Niveau1")
                SceneManager.LoadScene("Level2");
            else if (niveauTermine == "Niveau2")
                SceneManager.LoadScene("Level3");
            else if (niveauTermine == "Niveau3")
                SceneManager.LoadScene("MainMenu");
        }
    }
}
