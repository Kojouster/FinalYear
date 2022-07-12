using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBulletsScript : MonoBehaviour
{
    [SerializeField] float DestroyTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
