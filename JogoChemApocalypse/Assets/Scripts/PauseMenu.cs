using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool JogoPausado = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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

    void Voltar()
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
