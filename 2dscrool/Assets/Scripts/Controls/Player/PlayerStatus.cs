using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public PlayerType State { get { return state; } set { state = value; } }
    public PlayerType state = PlayerType.IDEL;
    public enum PlayerType
    {
        IDEL,
        RUN,
        JUMP,
        ATK,
    }
    
}
