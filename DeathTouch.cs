using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTouch : MonoBehaviour
{
    public BoxCollider2D hazard;
    public BoxCollider2D player;
    public string level;


    void Update()
    {
        if (hazard.IsTouching(player))
        {
            ResetLevel();
        }
    }
       
    void ResetLevel()
    {
        Application.LoadLevel(level);
    }
}
