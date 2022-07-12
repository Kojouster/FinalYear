using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveLoadGame : MonoBehaviour
{

    public SaveScript ss;
    [SerializeField] GameObject LoadingConfirmedTxt;
    [SerializeField] GameObject LoadingConfirmedIcon;


    public int DataExist = 10;
    [SerializeField] Text LoadButton;

    Color color1;
 
    // Start is called before the first frame update
    void Start()
    {
        LoadButton.color = Color.grey;
        LoadButton.raycastTarget = false;
        
        LoadingConfirmedTxt.SetActive(false);
        LoadingConfirmedIcon.SetActive(false);

        DataExist = PlayerPrefs.GetInt("PlayersHealth",0);
        if (DataExist > 0)
        {
            ColorUtility.TryParseHtmlString("F9E5CF", out color1);
            LoadButton.color = color1;
            LoadButton.raycastTarget = true;

        }

       
    }
    public void SaveGame()
    {
        PlayerPrefs.SetInt("PlayersHealth", ss.playerHealth);
        PlayerPrefs.SetFloat("BatteryPowers", ss.BatteryPower);
        PlayerPrefs.SetInt("Apples", ss.Apples);
        PlayerPrefs.SetInt("Batteries", ss.Batteries);
        PlayerPrefs.SetInt("PistolAmmo", ss.PistolAmmo);
        PlayerPrefs.SetInt("Arrows", ss.Arr);
        PlayerPrefs.SetInt("PistolBullets", ss.pistolBullets);
        PlayerPrefs.SetInt("ApplesL", ss.ApplesLeft);
        PlayerPrefs.SetInt("AmmoL", ss.AmmoLeft);
        PlayerPrefs.SetInt("BatteryL", ss.BatLeft);
        PlayerPrefs.SetInt("ArrowsL", ss.ArrowsLeft);

        PlayerPrefs.SetInt("CabinL", ss.cabKLeft);
        PlayerPrefs.SetInt("HouseL", ss.houseKLeft);
        PlayerPrefs.SetInt("RoomL", ss.roomKLeft);


        PlayerPrefs.SetInt("Enemy1Alive", ss.Enemy1);
        PlayerPrefs.SetInt("Enemy2Alive", ss.Enemy2);
        PlayerPrefs.SetInt("Enemy3Alive", ss.Enemy3);

        PlayerPrefs.SetInt("Enemy4Alive", ss.Enemy4);
        PlayerPrefs.SetInt("Enemy5Alive", ss.Enemy5);
        PlayerPrefs.SetInt("Enemy6Alive", ss.Enemy6);



        if (ss.knife == true)
            PlayerPrefs.SetInt("knifeInventory", 1);

        if (ss.bat == true)
            PlayerPrefs.SetInt("batInventory", 1);

        if (ss.axe == true)
            PlayerPrefs.SetInt("axeInventory", 1);

        if (ss.pistol == true)
            PlayerPrefs.SetInt("pistolInventory", 1);

        if (ss.crossBow == true)
            PlayerPrefs.SetInt("crossbowInventory", 1);

        if (ss.roomKey == true)
            PlayerPrefs.SetInt("roomkeyInventory", 1);

        if (ss.houseKey == true)
            PlayerPrefs.SetInt("housekeyInventory", 1);

        if (ss.cabinKey == true)
            PlayerPrefs.SetInt("cabinkeyInventory", 1);

        if (ss.ArrowRefil == true)
            PlayerPrefs.SetInt("ArrowR", 1);


       
         PlayerPrefs.Save();


        StartCoroutine(SaveGameTxt());

    }

    public void loadGame()
    {

        ss.savedGame = true;
       

    }

    IEnumerator SaveGameTxt()
    {
        Time.timeScale = 1;
        LoadingConfirmedTxt.SetActive(true);
        LoadingConfirmedIcon.SetActive(true);
        yield return new WaitForSeconds(3.0f);

        Time.timeScale = 0;
        LoadingConfirmedTxt.SetActive(false);
        LoadingConfirmedIcon.SetActive(false);

    }
}
