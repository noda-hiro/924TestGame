using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerStatus;

public class PlayerControl : MonoBehaviour
{
    static public PlayerControl instance;
    public FloorCheak floor;
    public PlayerType status;

    public bool isRight = false;
    private bool isFloor;

    Rigidbody2D rb2d;
    private Slider jumpCoolDownslider;
    [SerializeField] private float jumpCoolDownTimer = 1f;
    [SerializeField] private bool jumpCoolDownFlag = false;
    [SerializeField] private float flap = 100f;
    [SerializeField] private float speed = 0.5f;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        jumpCoolDownslider = GameObject.Find("JumpCoolDownBar").GetComponent<Slider>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    #region ˆÚ“®ˆ—
    public void PlayerMove()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        if (horizontalKey > 0)
        {
            rb2d.velocity += new Vector2(speed, 0) * (Time.deltaTime * 300);
            transform.localScale = new Vector3(-1, 1, 1);
            isRight = true;
        }
        if (horizontalKey < 0)
        {
            rb2d.velocity -= new Vector2(speed, 0) * (Time.deltaTime * 300);
            transform.localScale = new Vector3(1, 1, 1);
            isRight = false;
        }
        if (horizontalKey == 0)
            rb2d.velocity = Vector2.zero;
    }
    #endregion
    #region jumpˆ—
    public void PlayerJump()
    {
        var rightJump = Input.GetKeyDown(KeyCode.Space) && !jumpCoolDownFlag && isRight;
        var leftJump = Input.GetKeyDown(KeyCode.Space) && !jumpCoolDownFlag && isRight==false;
        if (rightJump)
        {
            rb2d.velocity = (Vector2.right/4+ Vector2.up) * flap;
            jumpCoolDownFlag = true;
        }
        else if (leftJump)
        {
            rb2d.velocity = (-Vector2.right/4 + Vector2.up) * flap;
            jumpCoolDownFlag = true;
        }
        JumpCoolDown();
    }
    public void JumpCoolDown()
    {
        if (jumpCoolDownFlag)
            jumpCoolDownTimer -= 0.25f * Time.deltaTime;
        if (jumpCoolDownTimer < 0)
        {
            jumpCoolDownTimer = 1f;
            jumpCoolDownFlag = false;
        }
        CoolTimeBar();
    }
    private void CoolTimeBar()
    {
        jumpCoolDownslider.value = jumpCoolDownTimer;
    }
    #endregion


}
