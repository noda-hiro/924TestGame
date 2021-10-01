using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject head;
    static public EnemyControl instance;
    [SerializeField] float moveRange = 10f;
    private bool isSee = false;
    [SerializeField] float enemyAttackSpeed = 8f;
    [SerializeField] float enemyAttackRange = 100f;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        
    }

    // Update is called once per frame
    void OnWillRenderObject()
    {
        isSee = true;
    }
    public void MoveEnemy()
    {
        if (isSee)
            transform.position -= transform.right * moveRange * Time.deltaTime;
    }
    public void idelEnemy()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y);
    }
   
  

}
