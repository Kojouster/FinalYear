using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingFall : MonoBehaviour
{
    public Animation anim;
    public AudioSource paintFell;
    // Start is called before the first frame update
    void Start()
    {
    
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim["paintingDrop"].speed = 0.5f;
            anim.Play("paintingDrop");
            paintFell.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this);
    }
}
