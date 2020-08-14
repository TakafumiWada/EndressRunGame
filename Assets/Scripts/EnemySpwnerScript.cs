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
        GameObject obj= Instantiate(enemy[i]);//blueEnemyかredEnemyのどちらかをランダムで生成。生成したenemy[i]を↓で変数「obj」として扱わせる
        obj.transform.parent=ground.transform;//objをthisの子にする(子にしないとgroundの外に生成されてしまう)
        float random=Random.Range(-1.8f,1.8f);//-1.8f,1.8fはGroundの両端の座標
        obj.transform.position=new Vector3(random,this.transform.position.y,this.transform.position.z);//Groundの端から端までのランダムな箇所にobjを配置
    }
}
