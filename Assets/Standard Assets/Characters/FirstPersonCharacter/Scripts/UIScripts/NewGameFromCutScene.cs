using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameFromCutScene : MonoBehaviour
{
    public SaveScript ss;
   
    // Start is called before the first frame update
    void Start()
    {
        ss.NewGame = true;
        SceneManager.LoadScene("HorrorScene 1");
        // Deleting previously saved player pos
        PlayerPrefs.DeleteKey("PlayerX");
        PlayerPrefs.DeleteKey("PlayerY");
        PlayerPrefs.DeleteKey("PlayerZ");
        PlayerPrefs.DeleteKey("TimeToLoad");
        PlayerPrefs.DeleteKey("Saved");
    }


}
