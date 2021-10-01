using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    static public PlayerAttack instance;

    Vector2 playerAtkPos;
    Vector2 playerPos;
  [SerializeField]  float timer = 0.5f;
    [SerializeField] private float atkRange = 600f;
    [SerializeField] private float atkSpeed = 100f;
    [SerializeField] GameObject player;
   public bool atkTimer = false;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        AtkCoolTime();
    }
    #region çUåÇ(çUåÇîªíËÇÃìÆÇ©Çµ,ñﬂÇµ)
    public void Attack()
    {
        atkTimer = true;
        if(PlayerControl.instance.isRight==false)
            this.transform.position += new Vector3(-atkSpeed, 0);
        else
            this.transform.position += new Vector3(atkSpeed, 0);
    }
    private void AtkCoolTime()
    {
        if (atkTimer)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                this.transform.position = new Vector3(playerPos.x, playerPos.y, 0);
                atkTimer = false;
                timer = 0.5f;
                Debug.Log("afafaf");
            }
        }
       
    }
    #endregion
}
