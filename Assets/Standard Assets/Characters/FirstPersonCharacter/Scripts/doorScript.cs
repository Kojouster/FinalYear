using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    private Animator anim;
    public bool isOpen = false;

    private AudioSource Player;
    [SerializeField] AudioClip cabinSound;
    [SerializeField] AudioClip roomSound;
    [SerializeField] AudioClip houseSound;

    [SerializeField] bool cabin;
    [SerializeField] bool house;
    [SerializeField] bool room;


    public bool locked;
    public string DoorType;


    public SaveScript ss;
    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
   public void Update()
    {
        checkDoorCondition();
    }
   public void checkDoorCondition()
    {
        if (cabin == true)
        {
            DoorType = "Cabin";
            if (ss.cabinKey == true)
            {
                locked = false;
            }
        
        }
        if (room == true)
        {
            DoorType = "Room";
            if (ss.roomKey == true)
            {
                locked = false;
            }

        }
        if (house == true)
        {
            DoorType = "House";
            if (ss.houseKey == true)
            {
                locked = false;
            }

        }
    }

    public void doorOpen()
    {

        if (isOpen == false)
        {

            anim.SetTrigger("OpenDoor");
            isOpen = true;

            if (cabin == true)
            {
                Player.clip = cabinSound;
                Player.Play();
            
            }
            if (room == true)
            {
                Player.clip = roomSound;
                Player.Play();

            }
            if (house == true)
            {
                Player.clip = houseSound;
                Player.Play();

            }

        }
     
        else if (isOpen == true)
        {

            anim.SetTrigger("Close");
            isOpen = false;

            if (cabin == true)
            {
                Player.clip = cabinSound;
                Player.Play();

            }
            if (room == true)
            {
                Player.clip = roomSound;
                Player.Play();

            }
            if (house == true)
            {
                Player.clip = houseSound;
                Player.Play();

            }
        }

       
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (locked == false || locked == true)
            {

                if (isOpen == false)
                {
                    anim.SetTrigger("OpenDoor");
                    isOpen = true;

                }
            }
        
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (isOpen == true)
            {
                anim.SetTrigger("Close");
                isOpen = false;

            }
        }
    }
}
