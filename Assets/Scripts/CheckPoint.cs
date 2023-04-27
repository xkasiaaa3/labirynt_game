using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
[SerializeField] GameObject player;
[SerializeField] List<GameObject> checkPoints;
[SerializeField] Vector3 vectorPoint;
[SerializeField] float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health<1) {
            player.transform.position = vectorPoint;
        }
    }

    void OnControllerColliderHit(ControllerColliderHit other){
        if (checkPoints.Contains(other.gameObject)){
vectorPoint = player.transform.position;
checkPoints.Remove(other.gameObject);
Destroy(other.gameObject);}
    }
}
