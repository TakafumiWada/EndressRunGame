using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,5.0f);
    }

    // Update is called once per frame
    void Update()//1秒間で60回
    {
       
    }
}
