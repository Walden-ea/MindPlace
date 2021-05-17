using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


 
public class SettingsMenu : MonoBehaviour
{
    [SerializeField] GameObject Window;
    [SerializeField] GameObject settingsButton;
    public AudioSource audioScr;
    public void SetVolume(float volume)
    {
        audioScr.volume = volume;
    }

    public void Start()
    {
        Window.SetActive(false);
    }

    public void OpenMenu()
    {
        Window.SetActive(true);
        settingsButton.SetActive(false);

    }

    public void QuitMenu()
    {
         Window.SetActive(false);
         settingsButton.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void SetFullscreen(bool isFoolscreen)
    {
        Screen.fullScreen = isFoolscreen;
    }
}