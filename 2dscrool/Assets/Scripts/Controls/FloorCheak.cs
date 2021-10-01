using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheak : MonoBehaviour
{
    private string floorTag = "Floor";
    private bool isFloor = false;
    private bool isFloorEnter, isFloorStay, isFloorExit;
    #region ’…’n”»’è
    public bool IsFloor()
    {
        if(isFloorEnter||isFloorStay)
            isFloor = true;
        else if(isFloorExit)
            isFloor = false;

        isFloorEnter = false;
        isFloorStay = false;
        isFloorExit = false;
        return isFloor;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == floorTag)
            isFloorEnter = true;
        Debug.Log("afa");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == floorTag)
            isFloorStay = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == floorTag)
            isFloorExit = true;
    }
    #endregion
}
