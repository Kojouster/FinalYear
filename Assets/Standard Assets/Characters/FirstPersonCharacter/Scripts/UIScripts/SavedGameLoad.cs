using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavedGameLoad : MonoBehaviour
{
	public KeyCode _keyCode = KeyCode.Space;
	public GameObject loadingInfo, loadingIcon;
	private AsyncOperation async;
	[SerializeField] GameObject fadeOut;
	public SaveScript ss;

	IEnumerator Start()
	{
		

		loadingIcon.SetActive(true);
		loadingInfo.SetActive(false);
		yield return true;

		loadingIcon.SetActive(false);
		loadingInfo.SetActive(true);



	}

	void Update()
	{
		if (Input.GetKeyDown(_keyCode))
		{
			StartCoroutine(fade());
		

		}
	}

	IEnumerator fade()
	{
		fadeOut.SetActive(true);
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("HorrorScene 1");
		ss.savedGame = true;
	}
}
