using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicStickThrower : MonoBehaviour
{
    // public AudioClip throwSound;
    public Rigidbody magicStickPrefab;
    public float throwSpeed = 30.0f;
    public static bool canThrow = true;
      public float throwDelay = 0.5f; // Opóźnienie w sekundach

    private float throwTimer = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          throwTimer += Time.deltaTime;
         if (Input.GetButtonUp("Fire1") && canThrow && throwTimer >= throwDelay)
        {
        // GetComponent<AudioSource>().PlayOneShot(throwSound);
        Rigidbody newMagicStick = Instantiate(magicStickPrefab, transform.position, transform.rotation) as Rigidbody;
        newMagicStick.name = "magicStick";
        // Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newMagicStick.GetComponent<Collider>(), true);
        newMagicStick.velocity = transform.forward * throwSpeed;
         throwTimer = 0.0f; // Zresetuj timer
        }

    }
}
