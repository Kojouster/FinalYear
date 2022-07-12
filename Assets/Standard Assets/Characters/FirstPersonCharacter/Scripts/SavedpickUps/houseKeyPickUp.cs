using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseKeyPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int houseKeyNum;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkAmmo());
    }

    IEnumerator checkAmmo()
    {
        yield return new WaitForSeconds(1);
        if (houseKeyNum > ss.houseKLeft)
        {

            Destroy(gameObject);
        }
    }
}
