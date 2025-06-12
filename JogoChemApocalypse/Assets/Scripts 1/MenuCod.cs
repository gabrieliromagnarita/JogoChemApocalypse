using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCod : MonoBehaviour
{
   public void Jogar()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    public void Sair()
    {
        Debug.Log("SAIR");
        Application.Quit();
    }
}
