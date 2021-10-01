using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    static public EnemyAttack instance;
    [SerializeField] float enemyAttackSpeed = 2f;
    [SerializeField] float enemyAttackRange = 100f;
    float timer = 0.5f;
    float repeatTimer = 3f;
    bool enemyAtkTimer = false;
    bool repeatTimerFinished = false;
    Vector2 enemyPos;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = enemy.transform.position;
       EnemyAtkCoolTime();
     
    }
    //çUåÇèàóù playerÇÃÇ∆ìØÇ∂
    public void AttackEnemy()
    {
        enemyAtkTimer = true;
        this.transform.position += new Vector3(-enemyAttackSpeed, 0);
    }
    private void EnemyAtkCoolTime()
    {
        if (enemyAtkTimer)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                this.transform.position = new Vector3(enemyPos.x, enemyPos.y, 0);
                enemyAtkTimer = false;
                timer = 0.5f;
                Debug.Log("afafaf");
                
            }
        }
       
    }
}
