using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
[SerializeField] GameObject player;
[SerializeField] List<GameObject> checkPoints;
[SerializeField] Vector3 vectorPoint;
PlayerHealth playerHealth;
CharacterController controller;
[SerializeField] GameObject minotaur;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        controller = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
    {if (playerHealth!=null){
        
        if (playerHealth.getCurrentHealth()<1) {
          
          controller.enabled=false;
            player.transform.position = vectorPoint;
            playerHealth.getMax();
            if (minotaur!=null){minotaur.GetComponent<MinotaurController>().Reset();}
            controller.enabled=true;

}
        }}
    }
    
    
    void OnControllerColliderHit(ControllerColliderHit other){
        if (checkPoints.Contains(other.gameObject)){
vectorPoint = player.transform.position;
checkPoints.Remove(other.gameObject);
Destroy(other.gameObject);}
    }

    public GameObject getNextCheckpoint(){
        if (checkPoints.Count>0){
        return checkPoints[0];}
        else return null;
    }


}
