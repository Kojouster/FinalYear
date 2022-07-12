using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykilled : MonoBehaviour
{
    [SerializeField] int EnemyNumber;
    public SaveScript ss;
    void Start()
    {
        if (EnemyNumber == 1)
        {
            ss.Enemy1 = 0;
        }

        if (EnemyNumber == 2)
        {
            ss.Enemy2 = 0;
        }
        if (EnemyNumber == 3)
        {
            ss.Enemy3 = 0;
        }

        if (EnemyNumber == 4)
        {
            ss.Enemy4 = 0;
        }

        if (EnemyNumber == 5)
        {
            ss.Enemy5 = 0;
        }

        if (EnemyNumber == 6)
        {
            ss.Enemy6 = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
