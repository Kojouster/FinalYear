using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    private NavMeshAgent nav;

    [SerializeField] Animator ANIM;
    private NavMeshHit hit;
    private bool blocked = false;

    private bool runToPlayer = false;
    private float distToPlayer;
    private bool isChecking = true;
    private int failedChecks = 0;
    [SerializeField] Transform player;
    [SerializeField] GameObject enemy;
    [SerializeField] float maxRange = 35.0f;
    [SerializeField] int MaxChecks = 3;
    [SerializeField] float chaseSpeed = 8.5f;
    [SerializeField] float walkSpeed = 1.6f;
    [SerializeField] float AttackDist = 2.3f;
    [SerializeField] float AttackRotateSpeed = 2.0f;
    [SerializeField] float checkTime = 3.0f;


    [SerializeField] GameObject chaseSound;
    [SerializeField] GameObject HurtUI;

    [SerializeField] bool AIhaveKnife ;
    [SerializeField] bool AIHaveBat ;
    [SerializeField] bool AIHaveAxe ;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponentInParent<NavMeshAgent>();
        chaseSound.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAttackLogic();
    }

    void EnemyAttackLogic()
    {
        distToPlayer =  Vector3.Distance(player.position, enemy.transform.position);
        if (distToPlayer < maxRange)
        {
            if (isChecking == true)
            {
                isChecking = false;

                blocked = NavMesh.Raycast(transform.position, player.position, out hit, NavMesh.AllAreas);// accesing all areas of navmesh
                if (blocked == false)
                {
                    Debug.Log("I can see the player");
                    runToPlayer = true;
                    failedChecks = 0;
                
                }

                if (blocked == true)
                {
                    Debug.Log("Where bruh");
                    runToPlayer = false;
                    ANIM.SetInteger("AIState", 1);
                    failedChecks++;
                }

                StartCoroutine(TimedCheck());

            }

        
        }

        if (runToPlayer == true)// disabling move script on the enemy
        {
            enemy.GetComponent<EnemyMove>().enabled = false;
            chaseSound.gameObject.SetActive(true);
            if (distToPlayer > AttackDist)
            {
                nav.isStopped = false;
                ANIM.SetInteger("AIState", 2);
                nav.acceleration = 24;
                nav.SetDestination(player.position);
                nav.speed = chaseSpeed;
                HurtUI.gameObject.SetActive(false);
            }

            if (distToPlayer < AttackDist - 0.5f)
            {
                nav.isStopped = true;

                if (AIHaveAxe == true)
                {
                    ANIM.SetInteger("AIState", 3);

                }
                if (AIHaveBat == true)
                {
                    ANIM.SetInteger("AIState", 4);

                }
                if (AIhaveKnife == true)
                {
                    ANIM.SetInteger("AIState", 5);

                }
                //ANIM.SetInteger("AIState", 3);
                nav.acceleration = 180;
                HurtUI.gameObject.SetActive(true);
                // handling enemy rotation while attacking
                Vector3 Pos = (player.position - enemy.transform.position).normalized;
                Quaternion posRot = Quaternion.LookRotation(new Vector3(Pos.x, 0, Pos.z));
                enemy.transform.rotation = Quaternion.Slerp(enemy.transform.rotation, posRot, Time.deltaTime * AttackRotateSpeed);


            }

        }

        else if (runToPlayer == false)
        {
            nav.isStopped = true;
        
        
        }
    }

    //React animations when player hits the enemy
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            runToPlayer = true;
        
        }

        if (other.gameObject.CompareTag("pKnife"))
        {
            ANIM.SetTrigger("SmallReact");
           
        }

        if (other.gameObject.CompareTag("pAxe"))
        {
            ANIM.SetTrigger("BigReact");
           
        }

        if (other.gameObject.CompareTag("PBat"))
        {
            ANIM.SetTrigger("SmallReact");

        }
        if (other.gameObject.CompareTag("pCrossbow"))
        {
            ANIM.SetTrigger("BigReact");

        }
    }

    // Checking for the player
    IEnumerator TimedCheck()
    {

        yield return new WaitForSeconds(checkTime);
        isChecking = true;


        if (failedChecks > MaxChecks)  // switch AI back to patrol state
        {
            enemy.GetComponent<EnemyMove>().enabled = true;
            nav.isStopped = false;
            nav.speed = walkSpeed;

            failedChecks = 0;
            chaseSound.gameObject.SetActive(false);

        }
    
    }

}
