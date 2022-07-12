using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUps : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float distance = 4.0f;
    [SerializeField] GameObject pickUpMessage;

    [SerializeField] GameObject fullBatteriesTxt;
    [SerializeField] GameObject fullApplesTxt;
    [SerializeField] GameObject fullAmmoTxt;
    [SerializeField] GameObject fullArrowsTxt;

    [SerializeField] GameObject doorMessage;
    [SerializeField] Text DoorTxt;

    private float RayDistance;
    private bool canSeeTarget = false;
    private bool canSeeDoor = false;
    public doorScript ds;

    public SaveScript ss;
    // Audio Source
    private AudioSource PlayerAudio;
    [SerializeField] AudioClip PickUpSound;
    // Start is called before the first frame update

    //Player Arms
    [SerializeField] GameObject PlayerArms;
    void Start()
    {
        pickUpMessage.SetActive(false);
        fullBatteriesTxt.SetActive(false);
        fullApplesTxt.SetActive(false);
        fullAmmoTxt.SetActive(false);
        fullArrowsTxt.SetActive(false);
        doorMessage.SetActive(false);

        PlayerArms.SetActive(false);

        RayDistance = distance;

        PlayerAudio = GetComponent<AudioSource>();
        ds = GetComponent<doorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        pickObjectsOnSee();
       
     
       
    }


    void pickObjectsOnSee()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance)) // casting ray when character looks faced forward to the object
        {
            if (hit.transform.tag == "Apple")// sees the object when its tagged apple
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.Apples < 6)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();

                        Destroy(hit.transform.gameObject);
                        ss.ApplesLeft--;
                        ss.Apples++;
                    }
                
                }
            }


          else if (hit.transform.tag == "Battery" )// sees the object when its tagged Battery
          {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.Batteries < 4)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();

                        Destroy(hit.transform.gameObject);
                        ss.Batteries++;
                        ss.BatLeft--;
                    }

                }
          }
            else if (hit.transform.tag == "Knife")// sees the object when its tagged apple
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.knife == false)
                    {

                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        ss.knife = true;
                        Destroy(hit.transform.gameObject);
                    }
                }

            }
            //Bat Pick
            else if (hit.transform.tag == "Bat")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.bat == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.bat = true;
                    }


                }
            }
            // Axe pickable
            else if (hit.transform.tag == "Axe")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.axe == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.axe = true;
                    }


                }
            }
            //pistol pick
            else if (hit.transform.tag == "Pistol")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.pistol == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.pistol = true;
                    }


                }
            }
            //crossbow pick
            else if (hit.transform.tag == "Crossbow")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.crossBow == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.crossBow = true;
                    }

                }
            }

            else if (hit.transform.tag == "cabin")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.cabinKey == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);

                        ss.cabKLeft--;
                        ss.cabinKey = true;
                        
                    }

                }
            }
            else if (hit.transform.tag == "house")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.houseKey == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.houseKLeft--;
                        ss.houseKey = true;

                    }

                }
            }
            else if (hit.transform.tag == "room")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.roomKey == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.roomKLeft--;
                        ss.roomKey = true;
                    }

                }
            }
            else if (hit.transform.tag == "PistolAmmo")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.PistolAmmo < 4)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.AmmoLeft--;
                        ss.PistolAmmo ++;
                        
                       
                    }

                }
            }
            else if (hit.transform.tag == "Arrows")// sees the object when its tagged 
            {
                canSeeTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (ss.ArrowRefil == false)
                    {
                        PlayerAudio.clip = PickUpSound;
                        PlayerAudio.Play();
                        Destroy(hit.transform.gameObject);
                        ss.ArrowsLeft--;
                        ss.ArrowRefil = true;
                    }

                }
            }


            else if (hit.transform.tag == "Door")// sees the object when its tagged 
            {
               
                canSeeDoor = true;
                //checking if the door is locked or not
                if (hit.transform.gameObject.GetComponent<doorScript>().locked == false)
                {
                    if (hit.transform.gameObject.GetComponent<doorScript>().isOpen == false)
                    {
                        DoorTxt.text = "Press [E] to Open";

                    }

                    if (hit.transform.gameObject.GetComponent<doorScript>().isOpen == true)
                    {
                        DoorTxt.text = "Press [E] to Close";

                    }

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        hit.transform.gameObject.SendMessage("doorOpen");// passing the name of the method not the anim name

                    }
                }

                else if (hit.transform.gameObject.GetComponent<doorScript>().locked == true)
                {
                    DoorTxt.text = "You need a " + (hit.transform.gameObject.GetComponent<doorScript>().DoorType) + " key";
                }


            }


            else
            {
                canSeeTarget = false;
                canSeeDoor = false;

            }

            if (canSeeTarget == true)
            {
                
                pickUpMessage.SetActive(true);
                RayDistance = 1000f;

            }

            
            //removing the icon from the view
            else if (canSeeTarget == false)
            {
                
                pickUpMessage.SetActive(false);
                fullBatteriesTxt.SetActive(false);
                fullApplesTxt.SetActive(false);
                fullAmmoTxt.SetActive(false);
                fullArrowsTxt.SetActive(false);
                RayDistance = distance;
            }


            if (canSeeDoor == true)
            {

                doorMessage.SetActive(true);
                RayDistance = 1000f;

            }


            //removing the icon from the view
            else if (canSeeDoor == false)
            {

                doorMessage.SetActive(false);
                fullBatteriesTxt.SetActive(false);
                fullApplesTxt.SetActive(false);
                fullAmmoTxt.SetActive(false);
                fullArrowsTxt.SetActive(false);
                RayDistance = distance;
            }

            fullBatteriesWarning();
            fullApplesWarning();
            fullAmmoWarning();
            fullArrowsWarning();

        }
       

    }

    void fullArrowsWarning()
    {
        if (hit.transform.tag == "Arrows" && ss.Arr > 6 && canSeeTarget == true)
        {
            pickUpMessage.SetActive(false);
            fullArrowsTxt.SetActive(true);
            RayDistance = 1000f;


        }

    }
    void fullAmmoWarning()
    {
        if (hit.transform.tag == "PistolAmmo" && ss.PistolAmmo >= 4 && canSeeTarget == true)
        {
            pickUpMessage.SetActive(false);
            fullAmmoTxt.SetActive(true);
            RayDistance = 1000f;


        }

    }
    void fullBatteriesWarning()
    {

        if (hit.transform.tag == "Battery" && ss.Batteries >= 4 && canSeeTarget == true)
        {
            pickUpMessage.SetActive(false);
            fullBatteriesTxt.SetActive(true);
            RayDistance = 1000f;


        }


    }

    void fullApplesWarning()
    {


        if (hit.transform.tag == "Apple" && ss.Apples >= 6 && canSeeTarget == true)
        {
            pickUpMessage.SetActive(false);
            fullApplesTxt.SetActive(true);
            RayDistance = 1000f;


        }


    }

   
    

    


}
