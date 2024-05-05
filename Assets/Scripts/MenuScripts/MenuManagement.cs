using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    SoundManager sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.Find("Sonidos").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        sound.StopBGM();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void DeathScreen()
    {
        SceneManager.LoadScene(3);
    }
}
