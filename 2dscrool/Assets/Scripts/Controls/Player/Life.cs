using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
   public bool hpFInished=false;
    static public Life instance;
    [SerializeField] public GameObject[] playerlifes;

    void Start()
    {
        if (instance == null)
            instance = this;
    }

    #region EnemyÕ“Ë‚Ìƒn[ƒg‚ÌÁ–Åˆ—
    public void UpdateLife(int damage)
    {
     
       // for (i = 0; i < playerlifes.Length; i++)
         //   playerlifes[i].SetActive(true);
        switch (damage)
        {
            case 1:
                playerlifes[2].SetActive(false);
                Debug.Log("1”Ô–Ú");
                break;
            case 2:
                playerlifes[1].SetActive(false);
                Debug.Log("2”Ô–Ú");
                break;
            case 4:
                playerlifes[0].SetActive(false);
                hpFInished = true;
                Debug.LogError("3”Ô–Ú");
                break;
           
        }

    }
    #endregion
}
