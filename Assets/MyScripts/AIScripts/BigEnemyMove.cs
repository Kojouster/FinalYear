using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BigEnemyMove : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent nav;
    private Transform target;

    private float distToTarget;
    private int TargetNum = 1;

    private bool isStopped = false;
    private bool Randomizer = true;
    private int nextTargetNum;

    [SerializeField] float stopDistance = 2.0f;
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    [SerializeField] Transform target3;
    [SerializeField] Transform target4;
    [SerializeField] Transform target5;
    [SerializeField] Transform target6;
    [SerializeField] Transform target7;
    [SerializeField] Transform target8;
    [SerializeField] Transform target9;
    [SerializeField] Transform target10;
    [SerializeField] Transform target11;
    [SerializeField] Transform target12;
    [SerializeField] Transform target13;
    [SerializeField] Transform target14;
    [SerializeField] Transform target15;
    [SerializeField] Transform target16;
    [SerializeField] Transform target17;
    [SerializeField] Transform target18;

    [SerializeField] float waitTime = 2.0f;
    [SerializeField] int maxTargets = 18;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = target1;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveTheEnemy();
    }

    void MoveTheEnemy()
    {
        distToTarget = Vector3.Distance(target.position, transform.position); // Ai goest to the target 1
        if (distToTarget > stopDistance)
        {

            nav.SetDestination(target.position);
            nav.isStopped = false;
            anim.SetInteger("AIState", 0);
            nextTargetNum = TargetNum;
        }
        if (distToTarget < stopDistance)
        {
            nav.isStopped = true;
            anim.SetInteger("AIState", 1);
            StartCoroutine(LookAround());

          
           
        }

    }
    void SetTarget()
    {
        if (TargetNum == 1)
        {

            target = target1;
        }

        if (TargetNum == 2)
        {

            target = target2;
        }
        if (TargetNum == 3)
        {

            target = target3;
        }
        if (TargetNum == 4)
        {

            target = target4;
        }
        if (TargetNum == 5)
        {

            target = target5;
        }
        if (TargetNum == 6)
        {

            target = target6;
        }
        if (TargetNum == 7)
        {

            target = target7;
        }
        if (TargetNum == 8)
        {

            target = target8;
        }
        if (TargetNum == 9)
        {

            target = target9;
        }
        if (TargetNum == 10)
        {

            target = target10;
        }



        if (TargetNum == 11)
        {

            target = target11;
        }

        if (TargetNum == 12)
        {

            target = target12;
        }

        if (TargetNum == 13)
        {

            target = target13;
        }

        if (TargetNum == 14)
        {

            target = target14;
        }

        if (TargetNum == 15)
        {

            target = target15;
        }

        if (TargetNum == 16)
        {

            target = target16;
        }
        if (TargetNum == 17)
        {

            target = target17;
        }
        if (TargetNum == 18)
        {

            target = target18;
        }

    }

    IEnumerator LookAround()
    {

        yield return new WaitForSeconds(waitTime);
        if (isStopped == false)
        {

            isStopped = true;
            if (Randomizer == true)
            {
                Randomizer = false;
                TargetNum = Random.Range(1, maxTargets);


                TargetNum++;
                if (TargetNum == nextTargetNum)
                {
                    TargetNum ++;
                    if (TargetNum >= maxTargets)
                    {

                        TargetNum = 1;

                    }
                }

               
            }
            SetTarget();
            yield return new WaitForSeconds(waitTime);
            isStopped = false;
            Randomizer = true;
        }
    }
}
