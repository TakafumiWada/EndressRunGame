using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugenSeieiScript : MonoBehaviour
{
    public GameObject[] ground;//無限生成したいステージ。配列にしてステージを複数個用意することで、ステージの単調化を避ける
    void OnTriggerEnter(Collider col)//透明な壁とPlayerが貫通したときに実行
    {
        if(col.gameObject.tag=="Player"){
            int i=Random.Range(0,3);//0以上3未満のint(整数)をrandに代入→0or1or2
            
            Instantiate(ground[i],new Vector3(0,0,this.transform.position.z+ground[i].transform.localScale.z), Quaternion.identity);
            //groundを生成する位置をこのオブジェクトの親の先端と一致させるために、GroundのzのScaleの値(この例だと25)だけ離れた地点に生成している
            Debug.Log("生成完了！");
        }
    }
}
