using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,10.0f);//PCが重くなるのを防ぐために通過後にしばらく経ったらGroundを消す
    }

   
}
