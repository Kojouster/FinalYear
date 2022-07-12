using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {

    public static string levelName;
	public string level;
	public SaveScript ss;
	public GameObject FadeOut;


	public void Start()
	{
		//slg.GetComponent<SaveLoadGame>();
		FadeOut.SetActive(false);
	}
	public void ContinueGame() 
	{
		SceneManager.LoadScene("HorrorScene 1");
		//
		//slg.loadGame();

	}
	
	
	public void LoadScene (string level) 
	{
		StartCoroutine(fadein(level));
	  

	}
	
	public void MainMenu () 
	{
		Time.timeScale = 1.0f; 
		//PlayerPrefs.SetString("lastLevel", levelName);
		PlayerPrefs.Save();
		SceneManager.LoadScene("MainMenu");
	}
	
	
	public void ApplicationExitSave ()
	{	
		//PlayerPrefs.SetString("lastLevel", levelName);
		PlayerPrefs.Save();
		Application.Quit();
	}
	
		
	public void ApplicationExit ()
	{	
		Application.Quit();
	}



	IEnumerator fadein(string level)
	{
		FadeOut.SetActive(true);
		yield return new WaitForSeconds(7);
		levelName = level;
		SceneManager.LoadScene("Loading");


	}
	

}