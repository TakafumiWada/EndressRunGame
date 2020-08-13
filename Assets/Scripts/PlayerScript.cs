using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    float speed=5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position+=new Vector3(0,0,speed*Time.deltaTime);
        if(Input.GetKey("right")){
            this.transform.position+=new Vector3(speed*Time.deltaTime,0,0);
        }
        if(Input.GetKey("left")){
            this.transform.position-=new Vector3(speed*Time.deltaTime,0,0);
        }
    }
}
