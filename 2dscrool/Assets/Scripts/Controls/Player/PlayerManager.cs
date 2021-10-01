using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public FloorCheak floor;

    private bool isFloor = false;
    private int damegeCount = 0;
    private int damege = 1;

    [SerializeField] private GameObject LifeBar;

    void Update()
    {
        if (GameControl.instance.gameOverFlag == false)
        {
            isFloor = floor.IsFloor();
            if (isFloor == true)
                PlayerControl.instance.PlayerMove();
            if (isFloor == true)
                PlayerControl.instance.PlayerJump();
            if (Input.GetKeyDown(KeyCode.B) && PlayerAttack.instance.atkTimer == false)
                PlayerAttack.instance.Attack();
        }
    }
    #region EnmeyÇ…ìñÇΩÇ¡ÇΩéûÇÃèàóù
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            damege += damegeCount;
            var hit = LifeBar.gameObject;
            var Lifes = hit.GetComponent<Life>();
            Lifes.UpdateLife(damege);
            damegeCount += 1;
            Debug.Log(damegeCount);
        }
        if (collision.gameObject.tag == "enemyATK")
        {
            var hit = LifeBar.gameObject;
            var Lifes = hit.GetComponent<Life>();
            Lifes.UpdateLife(damege);
            damegeCount++;
        }
    }

    #endregion

}
