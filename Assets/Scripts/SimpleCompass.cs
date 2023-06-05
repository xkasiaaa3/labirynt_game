using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCompass : MonoBehaviour
{
   
    public Transform player;
    private GameObject targetObject; // The object to navigate towards
   

    void Update()
    {
        targetObject = GameObject.FindGameObjectWithTag("Player").GetComponent<CheckPoint>().getNextCheckpoint();

        if (targetObject != null)
        {

            Vector3 target = targetObject.transform.position;
            Vector3 relativeTarget = player.parent.InverseTransformPoint(target);
            float rotation = Mathf.Atan2(-relativeTarget.x,relativeTarget.z)*Mathf.Rad2Deg;
            transform.localRotation=Quaternion.Euler(0,0,rotation);
        
        }
        else{
gameObject.SetActive(false);
        }
    }
}
