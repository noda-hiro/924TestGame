using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    //“¥‚Ü‚ê‚½‚Æ‚«‚Ìˆ—
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            transform.parent.gameObject.SetActive(false);
    }
}
