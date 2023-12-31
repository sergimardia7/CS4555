using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GamePaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void LoadMenu(){
        //Debug.Log("Loading Menu...");
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
