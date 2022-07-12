using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowsPickups : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int ArrowsNum;
    public SaveScript ss;
    void Start()
    {
        StartCoroutine(checkApples());
    }

    IEnumerator checkApples()
    {
        yield return new WaitForSeconds(1);
        if (ArrowsNum > ss.ArrowsLeft)
        {

            Destroy(gameObject);
        }
    }
}
