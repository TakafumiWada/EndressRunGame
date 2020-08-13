using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugenSeieiScript : MonoBehaviour
{
    public GameObject[] ground;//生成したいオブジェクト(さらにループさせるためには、このオブジェクトにもMugenSeiseiScriptがついている透明な壁が必要)
    void OnTriggerEnter(Collider col)//透明な壁とPlayerが貫通したときに実行
    {
        if(col.gameObject.tag=="Player"){
            int i=Random.Range(0,3);//0以上3未満のint(整数)をrandに代入→0or1or2
            
            Instantiate(ground[i],new Vector3(0,0,this.transform.position.z+12.5f), Quaternion.identity);
            //groundを生成する位置をこのオブジェクトの親の先端と一致させるために、GroundのzのScale25の半分の12.5を加えている
            Debug.Log("生成完了！");
        }
    }
}
