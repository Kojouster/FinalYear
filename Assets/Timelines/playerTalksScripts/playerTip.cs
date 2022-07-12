using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTip : MonoBehaviour
{
    [SerializeField] public GameObject pTip;

    private void Start()
    {
        pTip.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pTip.SetActive(true);
            StartCoroutine(delayDestroy());
        }
    }

    IEnumerator delayDestroy()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this.gameObject);
    }
}
