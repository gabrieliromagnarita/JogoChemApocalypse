using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverNew : MonoBehaviour
{
    public GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    public void chamaMenu()
    {
        SceneManager.LoadScene("telaMenu");
    }

    public void sair()
    {
        Application.Quit();
    }
    public void reiniciarJogo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
