using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurHealth : MonoBehaviour
{
     public int maxHealth=200;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage){
        currentHealth-=damage;

        Debug.Log("Atak na minotaura "+currentHealth);
    }

    public void getMax(){
        currentHealth=maxHealth;
    }

    public int getCurrentHealth(){
        return currentHealth;
    }
}
