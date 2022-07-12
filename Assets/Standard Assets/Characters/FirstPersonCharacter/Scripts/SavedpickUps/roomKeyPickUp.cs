using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomKeyPickUp : MonoBehaviour
{
    [SerializeField] int roomKeyNum;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkAmmo());
    }

    IEnumerator checkAmmo()
    {
        yield return new WaitForSeconds(1);
        if (roomKeyNum > ss.roomKLeft)
        {

            Destroy(gameObject);
        }
    }
}
