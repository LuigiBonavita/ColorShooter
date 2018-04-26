using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoolManager : MonoBehaviour
{

    Vector3 poolOutOfScreen = new Vector3(3000, 3000, 3000);

    public EnemyMovement EnemyPrefab;
    public EnemyMovement enemyPrefab;
    public EnemyMovement Enemyprefab;
    public int MaxEnemies = 5;


    List<EnemyMovement> bullets = new List<EnemyMovement>();

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < MaxEnemies; i++)
        {
            EnemyMovement enemytoadd = Instantiate(EnemyPrefab);
            EnemyMovement enemyToadd = Instantiate(enemyPrefab);
            EnemyMovement enemytoAdd = Instantiate(Enemyprefab);
        }
    }
}
