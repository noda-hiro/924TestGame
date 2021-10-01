using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public enum enmeyStatus
    { ATK, RUN, IDEL }
    BoxCollider2D box;
    public enmeyStatus status;
    private int damageCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        status = enmeyStatus.RUN;
    }

    // Update is called once per frame
    void Update()
    {
        //gameoverflagがfalseなら実行
        if (GameControl.instance.gameOverFlag == false)
            ActionList();
    }
    public void ActionList()
    {
        switch (status)
        {
            case enmeyStatus.RUN:
                EnemyControl.instance.MoveEnemy();
                break;
            case enmeyStatus.ATK:
                Debug.Log("停止");
             EnemyAttack.instance.AttackEnemy();
                break;
            case enmeyStatus.IDEL:
                EnemyControl.instance.idelEnemy();
                break;
        }
    }
    //zone&Atkにあったりはいった時の処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Zone")
            status = enmeyStatus.ATK;
        if (collision.gameObject.tag == "Atk")
        {
            damageCount += 1;
            if(damageCount==3)
            this.gameObject.SetActive(false);
            
        }
    }
    //zone tagのついたオブジェクトから抜けたときの処理
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Zone")
            status = enmeyStatus.RUN;
    }


}

