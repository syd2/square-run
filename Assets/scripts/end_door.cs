using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_door : MonoBehaviour
{
    public GameMaster gameMaster;

   void OnTriggerEnter2D(Collider2D col)
    {
        
        gameMaster.floorComplete();

    }
}

