using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target.transform.position.y > 2){
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y,-10);
        }else if(target.transform.position.y < 3){
            transform.position = new Vector3(target.transform.position.x, transform.position.y,-10);
        }
    }
}
