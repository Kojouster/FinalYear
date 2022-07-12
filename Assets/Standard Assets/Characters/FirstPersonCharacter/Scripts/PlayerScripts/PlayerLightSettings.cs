using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerLightSettings : MonoBehaviour
{
    [SerializeField] PostProcessVolume MyVolume;
    [SerializeField] PostProcessProfile StandardShader;
    [SerializeField] PostProcessProfile NightVisShader;

    [SerializeField] GameObject NighVisionImg;
    [SerializeField] GameObject FlashLight;

    [SerializeField] AudioSource flashOnandOff;
    [SerializeField] AudioSource nightVisSound;
  //  [SerializeField] GameObject enemyFlashLight;

    private bool NightVisActive = false;
    private bool FlashLightActive = false;

    public SaveScript ss;


    private void Start()
    {
        NighVisionImg.SetActive(false);    // setting nigh vision off when game starts
        FlashLight.SetActive(false);      // setting flash light off when game starts
       // enemyFlashLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SwitchToNightVision();
        FlashLightOnAndOff();
        ManagingPower();
    }

    void SwitchToNightVision()
    {
        if (ss.BatteryPower >= 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.N)) // When N key is pressed post proccesing profile will change to night vision shader
            {
                if (NightVisActive == false)
                {
                    NighVisionImg.SetActive(true);
                    MyVolume.profile = NightVisShader;
                    NightVisActive = true;
                    ss.NightVisOn = true;
                    nightVisSound.Play();

                }

                else if (NightVisActive == true)
                {
                    NighVisionImg.SetActive(false);
                    MyVolume.profile = StandardShader;
                    NightVisActive = false;
                    ss.NightVisOn = false;
                    flashOnandOff.Play();
                }


            }
        }
        
    }

    void FlashLightOnAndOff() // method for switching the flash light
    {
        if (ss.BatteryPower >= 0.0f )
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                if (FlashLightActive == false)
                {
                    FlashLight.SetActive(true);
                  //  enemyFlashLight.SetActive(true);
                    FlashLightActive = true;
                    ss.FlashLightOn = true;
                    flashOnandOff.Play();

                }

                else if (FlashLightActive == true)
                {
                    FlashLight.SetActive(false);
                   // enemyFlashLight.SetActive(false);
                    FlashLightActive = false;
                    ss.FlashLightOn = false;
                    flashOnandOff.Play();

                }

            }
        }
    }
    void ManagingPower()
    {
        if (ss.BatteryPower <= 0) // if power less than 0 turn off the flash light
        {

            FlashLight.SetActive(false);
            FlashLightActive = false;
            ss.FlashLightOn = false;
           // enemyFlashLight.SetActive(false);

        }

        if (ss.BatteryPower <= 0) // turn off the night vision
        {

            NighVisionImg.SetActive(false);
            MyVolume.profile = StandardShader;
            NightVisActive = false;
            ss.NightVisOn = false;


        }



    }
}
