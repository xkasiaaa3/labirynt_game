using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurShout : MonoBehaviour
{
    public AudioSource shoutAudio;
    // Start is called before the first frame update
    void Start()
    {
        shoutAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shout(){
        shoutAudio.Play();
    }
}
