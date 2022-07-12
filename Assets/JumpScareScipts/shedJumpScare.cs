using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shedJumpScare : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animation anim;
    [SerializeField] AudioSource drop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("chairTwist");
            drop.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this);
    }

}
