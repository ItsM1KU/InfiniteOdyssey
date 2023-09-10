using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class mainMenu : MonoBehaviour
{
    [SerializeField] AudioSource sfx;

    public void playButton()
    {
        sfx.Play();
    }
    public void playGame()
    {
        SceneManager.LoadScene("Boardscene");
    }

    public void stopGame()
    {
        Application.Quit();
        //Debug.Log("Quit");
    }
}
