using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Admanager.instance.RequestBanner();
    }
    public void QuitGame()
    {
        Debug.Log("I am Quiting.");
        Application.Quit();
    }
  public void backToSetting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
       // Admanager.instance.RequestBanner();
    }
}
