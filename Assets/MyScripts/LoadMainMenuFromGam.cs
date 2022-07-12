using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainMenuFromGam : MonoBehaviour
{
    [SerializeField] Button mainMenu;
    // Start is called before the first frame update

    public void Awake()
    {
       
        SceneManager.LoadScene("MainMenu");
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReturnToMainMenu()
    {

   
       

    }
}
