using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
 {
    public BoxCollider2D endGoal;
    public BoxCollider2D player;
    public string level;


    void Update()
    {
        if (player.IsTouching(endGoal))
        {
            ResetLevel();
        }
    }

    void ResetLevel()
    {
        Application.LoadLevel(level);
    }
}