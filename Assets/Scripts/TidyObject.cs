using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TidyObject : MonoBehaviour
{
    public float removeTime = 0.25f;
    MinotaurHealth minotaurHealth;
    // Start is called before the first frame update
    void Start()
    {
        minotaurHealth = GameObject.FindGameObjectWithTag("Minotaur").GetComponent<MinotaurHealth>();
    }

    // Update is called once per frame
   
   void OnCollisionEnter(Collision theObject) {
        if (theObject.gameObject.name == "Terrain") {
            Destroy(gameObject, removeTime);
        }
        if (theObject.gameObject.name == "Minotaur"){
            minotaurHealth.takeDamage(20);
        }
    }
}
