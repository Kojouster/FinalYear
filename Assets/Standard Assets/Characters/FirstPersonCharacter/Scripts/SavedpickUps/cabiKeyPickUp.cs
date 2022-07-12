using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabiKeyPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int  cabKeyNum;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkAmmo());
    }

    IEnumerator checkAmmo()
    {
        yield return new WaitForSeconds(1);
        if (cabKeyNum > ss.cabKLeft)
        {

            Destroy(gameObject);
        }
    }
}
