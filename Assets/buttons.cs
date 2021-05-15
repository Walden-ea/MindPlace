using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
     public void Restart_button()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }

    // Update is called once per frame
     public void pause_button()
    {
        if (Time.timeScale != 0)
        { 
            Time.timeScale = 0;

        }
        else Time.timeScale = 1;
    }
}
