using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenu : MonoBehaviour

{
    public GameObject menu;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(menu.activeSelf)
            {
                menu.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
            }
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()

    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
        }
          
    }
}
