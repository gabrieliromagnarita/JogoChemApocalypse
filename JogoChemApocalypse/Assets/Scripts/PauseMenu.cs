using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool JogoPausado = false;
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (JogoPausado)
            {
                Voltar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void chamaMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("telaMenu");
    }

    public void sair()
    {
        Application.Quit();
    }

    public void Voltar()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        JogoPausado = false;
    }

    void Pausar()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        JogoPausado = true;
    }
}
