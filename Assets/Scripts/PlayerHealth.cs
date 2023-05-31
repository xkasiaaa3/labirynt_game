using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth=100;
    private int currentHealth;
    CheckPoint checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=maxHealth;
        checkpoint = GameObject.FindGameObjectWithTag("Player").GetComponent<CheckPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage){
        currentHealth-=damage;

        // if(currentHealth<1){
        //     checkpoint.respawn();
        //    // getMax();
        // }

       
    }

    public void getMax(){
        currentHealth=maxHealth;
    }

    public int getCurrentHealth(){
        return currentHealth;
    }
}
