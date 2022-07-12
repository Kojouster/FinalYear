using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedJump : MonoBehaviour
{
    [SerializeField] GameObject bedActivator;
    [SerializeField] GameObject hitDrama;
    [SerializeField] AudioSource drop;
    // Start is called before the first frame update
    void Start()
    {
        bedActivator.SetActive(false);
        hitDrama.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bedActivator.SetActive(true);
            hitDrama.SetActive(true);
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this);
        }
    }

    IEnumerator delayDrop()
    {
        yield return new WaitForSeconds(3.5f);
        drop.Play();
            
    }
}
