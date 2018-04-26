using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColor : MonoBehaviour {

    public Material RedMat;
    public Material BlueMat;
    public Material YellMat;
    public MeshRenderer rend;

    public string actualColor;

    private void OnEnable()
    {
        EventManager.Killed += ChangeColor;
    }

    private void OnDisable()
    {
        EventManager.Killed -= ChangeColor;
    }

    void ChangeColor(EnemyMovement Enemy)
    {
        switch (Enemy.enemyColor)
        {
            case EnemyMovement.EnemyColor.red:
                rend.materials = new Material[] { RedMat };
                actualColor = "red";
                break;
            case EnemyMovement.EnemyColor.blue:
                rend.materials = new Material[] { BlueMat };
                actualColor = "blue";
                break;
            case EnemyMovement.EnemyColor.yell:
                rend.materials = new Material[] { YellMat };
                actualColor = "yellow";
                break;
            default:
                break;
        }
    }
}
