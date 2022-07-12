using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carTrigger : MonoBehaviour
{
    [SerializeField] Animation anim;
    [SerializeField] GameObject hitMetal;
    [SerializeField] GameObject car;
    void Start()
    {
        hitMetal.SetActive(false);
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("carCrashAnim");
            hitMetal.SetActive(true);
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this);
        }
    }
}
