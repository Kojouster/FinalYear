using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour {

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
		fadeOut.SetActive(false);
		//ss = FindObjectOfType<SaveScript>();

	}

	void Update ()
	{
		if (Input.GetKeyDown(_keyCode))
		{
			StartCoroutine(fade());
			

		}
	}

	IEnumerator fade()
	{
		ss.NewGame = true;
		fadeOut.SetActive(true);
		yield return new WaitForSeconds(5f);
		

		SceneManager.LoadScene("OpeningCutScene");



	}
}