using UnityEngine;

public class SaveScript : MonoBehaviour
{
    public int playerHealth = 100;
    public bool healthChanged = false;

    public float BatteryPower = 1.0f;
    public bool BatteryRefil = false;

    public bool FlashLightOn = false;
    public bool NightVisOn = false;

    public bool knife = false;
    public bool bat = false;
    public bool axe = false;
    public bool pistol = false;
    public bool crossBow = false;

    public bool roomKey = false;
    public bool houseKey = false;
    public bool cabinKey = false;

    public int Apples = 0;
    public int Batteries = 0;

    public int PistolAmmo = 0;
    //public int Arrows = 0;

    public bool ArrowRefil = false;

    public bool haveKnife = false;
    public bool haveBat = false;
    public bool haveAxe = false;

    public bool havePistol = false;
    public bool haveCrossbow = false;

    public int pistolBullets = 12;
    public int Arr = 6;

    public int ApplesLeft = 20;
    public int AmmoLeft = 7;
    public int BatLeft = 20;
    public int ArrowsLeft = 3;
    public int cabKLeft = 1;
    public int houseKLeft = 1;
    public int roomKLeft = 1;

    public int Enemy1 = 1;
    public int Enemy2 = 1;
    public int Enemy3 = 1;
    public int Enemy4 = 1;
    public int Enemy5 = 1;
    public int Enemy6 = 1;

    public bool NewGame = false;
    public bool savedGame = false;
    public bool isDead = false;

   
   
    private void Start()
    {
        if (NewGame == true)
        {

            playerHealth = 100;
            healthChanged = true;

            BatteryPower = 1.0f;
            BatteryRefil = false;

            FlashLightOn = false;
            NightVisOn = false;

            knife = false;
            bat = false;
            axe = false;
            pistol = false;
            crossBow = false;

            roomKey = false;
            houseKey = false;
            cabinKey = false;

            Apples = 0;
            Batteries = 0;

            PistolAmmo = 0;
            //public int Arrows = 0;

            ArrowRefil = false;

            haveKnife = false;
            haveBat = false;
            haveAxe = false;

            havePistol = false;
            haveCrossbow = false;
            isDead = false;
            pistolBullets = 12;
            Arr = 6;

            //NewGame = false;
            ApplesLeft = 20;
            AmmoLeft = 7;
            BatLeft = 20;
            ArrowsLeft = 3;


            cabKLeft = 1;
            houseKLeft = 1;
            roomKLeft = 1;

             Enemy1 = 1;
             Enemy2 = 1;
             Enemy3 = 1;
             Enemy4 = 1;
             Enemy5 = 1;
             Enemy6 = 1;


        }

        if (savedGame == true)
        {
           
            //retriving data from player prefs
            playerHealth = PlayerPrefs.GetInt("PlayersHealth");
            healthChanged = true;
            BatteryPower = PlayerPrefs.GetFloat("BatteryPowers");
            Apples = PlayerPrefs.GetInt("Apples");
            Batteries = PlayerPrefs.GetInt("Batteries");
            PistolAmmo = PlayerPrefs.GetInt("PistolAmmo");
            Arr =  PlayerPrefs.GetInt("Arrows");
            pistolBullets= PlayerPrefs.GetInt("PistolBullets");
            ApplesLeft = PlayerPrefs.GetInt("ApplesL");
            AmmoLeft = PlayerPrefs.GetInt("AmmoL");
            BatLeft = PlayerPrefs.GetInt("BatteryL");
            ArrowsLeft = PlayerPrefs.GetInt("ArrowsL");

            cabKLeft = PlayerPrefs.GetInt("CabinL");
            houseKLeft = PlayerPrefs.GetInt("HouseL");
            roomKLeft = PlayerPrefs.GetInt("RoomL");

            Enemy1 = PlayerPrefs.GetInt("Enemy1Alive");
            Enemy2 = PlayerPrefs.GetInt("Enemy2Alive");
            Enemy3 = PlayerPrefs.GetInt("Enemy3Alive");

            Enemy4 = PlayerPrefs.GetInt("Enemy4Alive");
            Enemy5 = PlayerPrefs.GetInt("Enemy5Alive");
            Enemy6 = PlayerPrefs.GetInt("Enemy6Alive");

            if (PlayerPrefs.GetInt("knifeInventory") == 1 )
            {
                knife = true;
            }

            if (PlayerPrefs.GetInt("batInventory") == 1)
            {
                bat = true;
            }

            if (PlayerPrefs.GetInt("axeInventory") == 1)
            {
                axe = true;
            }

            if (PlayerPrefs.GetInt("pistolInventory") == 1)
            {
                pistol = true;
            }

            if (PlayerPrefs.GetInt("crossbowInventory") == 1)
            {
                crossBow = true;
            }

            if (PlayerPrefs.GetInt("roomkeyInventory") == 1)
            {
                roomKey = true;
            }

            if (PlayerPrefs.GetInt("housekeyInventory") == 1)
            {
                houseKey = true;
            }
            if (PlayerPrefs.GetInt("cabinkeyInventory") == 1)
            {
                cabinKey = true;
            }

            if (PlayerPrefs.GetInt("ArrowR") == 1)
            {
                ArrowRefil = true;
            }

            isDead = false;
            //savedGame = false;
            //PlayerPrefs.Save();
           
           
        }

    }
}
        


    


