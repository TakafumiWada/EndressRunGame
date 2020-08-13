using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwnerScript : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject ground;
    // Start is called before the first frame update
    void Start()
    {
        int i=Random.Range(0,2);
        GameObject obj= Instantiate(enemy[i]);
        obj.transform.parent=ground.transform;//objをthisの子にする
        float random=Random.Range(-1.8f,1.8f);
        obj.transform.position=new Vector3(random,this.transform.position.y,this.transform.position.z);//子をランダムな位置に配置させる
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
