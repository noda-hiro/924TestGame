using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearBar : MonoBehaviour
{
    //クリアポイント到着で実行
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            GameControl.instance.gameClearFlag = true;
        }
    }
}
