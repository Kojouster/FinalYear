using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int AmmoNum;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkAmmo());
    }

    IEnumerator checkAmmo()
    {
        yield return new WaitForSeconds(1);
        if (AmmoNum  > ss.AmmoLeft)
        {

            Destroy(gameObject);
        }
    }
}
