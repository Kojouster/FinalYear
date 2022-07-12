using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipCutScene : MonoBehaviour
{
    public SaveScript ss;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ss.NewGame = true;
            SceneManager.LoadScene("HorrorScene 1");
            PlayerPrefs.DeleteKey("PlayerX");
            PlayerPrefs.DeleteKey("PlayerY");
            PlayerPrefs.DeleteKey("PlayerZ");
            PlayerPrefs.DeleteKey("TimeToLoad");
            PlayerPrefs.DeleteKey("Saved");
        }
    }
}
