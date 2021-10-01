using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    public EnemyStatusType State { get { return state; } set { state = value; } }
    public EnemyStatusType state = EnemyStatusType.RUN;
    public enum EnemyStatusType
    {
        RUN,
        ATK,
    }
}
