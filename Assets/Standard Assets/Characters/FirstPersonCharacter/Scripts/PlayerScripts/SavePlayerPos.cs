using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPos : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        PlayerPosLoad();
    }
    void Start()
    {
       
        if (PlayerPrefs.GetInt("Saved") == 1 && PlayerPrefs.GetInt("TimeToLoad") == 1)
        {
            float px = player.transform.position.x;
            float py = player.transform.position.y;
            float pz = player.transform.position.z;
        
            px = PlayerPrefs.GetFloat("PlayerX");
            py = PlayerPrefs.GetFloat("PlayerY");
            pz = PlayerPrefs.GetFloat("PlayerZ");
            player.transform.position = new Vector3(px, py, pz);
            PlayerPrefs.SetInt("TimeToLoad", 0);
            PlayerPrefs.Save();
        }
    }

    public void playerPosSave()
    {
        PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", player.transform.position.z);
        PlayerPrefs.SetInt("Saved", 1);

        PlayerPrefs.Save();

    }

    public void PlayerPosLoad()
    {
        PlayerPrefs.SetInt("TimeToLoad", 1);
        PlayerPrefs.Save();

    }
   
}
