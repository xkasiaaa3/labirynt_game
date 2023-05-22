using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicScriptThrower : MonoBehaviour
{
    // public AudioClip throwSound;
    public Rigidbody magicStickPrefab;
    public float throwSpeed = 30.0f;
    public static bool canThrow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1") && canThrow){
        // GetComponent<AudioSource>().PlayOneShot(throwSound);
        Rigidbody newMagicStick = Instantiate(magicStickPrefab, transform.position, transform.rotation) as Rigidbody;
        newMagicStick.name = "magicStick";
        // Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newMagicStick.GetComponent<Collider>(), true);
        newMagicStick.velocity = transform.forward * throwSpeed;
        }
    }
}
