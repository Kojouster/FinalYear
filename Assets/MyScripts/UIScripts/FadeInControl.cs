using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInControl : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        fadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
