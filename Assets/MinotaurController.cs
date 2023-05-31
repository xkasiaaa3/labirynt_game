using UnityEngine;
using UnityEngine.AI;

public class MinotaurController : MonoBehaviour
{
    public float movementSpeed = 6.0f;
    public float detectionRange = 30f;
    public float attackRange = 1f;
    public float attackDelay =3f;
    private float attackTimer = 0.0f;
    public float randomDelay = 9.0f; // Opóźnienie w sekundach
    private float randomTimer = 0.0f;
    private Transform player;
    private Animator animator;
    private bool isAwareOfPlayer = false;
    PlayerHealth playerHealth;
    Rigidbody rb;
    MinotaurHealth minotaurHealth;
    private bool isDead = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        animator = GetComponent<Animator>();
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        minotaurHealth = GetComponent<MinotaurHealth>();
    }

    private void Update()
    {
        if (!isDead){
            if ((IsPlayerInRange()||minotaurHealth.getCurrentHealth()<minotaurHealth.maxHealth)&&!isAwareOfPlayer)
        {
          
            isAwareOfPlayer = true;
        }

        if (isAwareOfPlayer)
        { 
            transform.LookAt(player.position);
            ChasePlayer();
        }
        else
        {
            Wander();
        }}

if(!isDead && minotaurHealth.getCurrentHealth()<1){
    animator.SetTrigger("Die");
    isDead = true;
    isAwareOfPlayer = false;
animator.SetBool("IsRunning", false);
}

    }

    private bool IsPlayerInRange()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        return distanceToPlayer <= detectionRange;
    }

private bool IsPlayerInAttackRange()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        return distanceToPlayer <= attackRange;
    }

    private void ChasePlayer()
    { animator.SetBool("IsRunning", true);

attackTimer += Time.deltaTime;
if (IsPlayerInAttackRange()&&attackTimer>=attackDelay){

    animator.SetTrigger("Attack");
    Debug.Log("Attack!");
    if (playerHealth!=null){
        playerHealth.takeDamage(30);
        Debug.Log(playerHealth.getCurrentHealth());
    }

    attackTimer=0.0f;
}

        // Vector3 direction = (player.position - transform.position).normalized;
        // transform.position += direction * movementSpeed * Time.deltaTime;
        // transform.LookAt(player.position);

        // Trigger the running animation
       
    }

    private void Wander()
    {
        // Implement your logic for random movement here
        randomTimer += Time.deltaTime; 
         if (randomTimer >= randomDelay){
        // Trigger the idle or shout animation based on chance
        float randomValue = Random.value;
       
        if (randomValue < 0.5f)
        {
            animator.SetTrigger("Shout");
          
            
        }
  randomTimer = 0.0f;

         }
    }

    public void Reset(){
isAwareOfPlayer = false;
animator.SetBool("IsRunning", false);
animator.SetTrigger("Reset");
animator.ResetTrigger("Attack");
    }


//     private void OnCollisionEnter(Collision col){
//         if(col.gameObject.name=="Terrain"){
//         Debug.Log("KOLIZJA");
// rb.velocity=Vector3.zero;
//         }
//     }
}