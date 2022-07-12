using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monolog1 : MonoBehaviour
{
    [SerializeField] GameObject monolog1Timeline;

    private void Start()
    {
        monolog1Timeline.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            monolog1Timeline.SetActive(true);
            StartCoroutine(delayDestroy());

        }
    }

    IEnumerator delayDestroy()
    {
        yield return new WaitForSeconds(1.5f);
       
        Destroy(this.gameObject);

    }
}
