using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShootInput : MonoBehaviour
{
    [Header("Input Settings")]

    Vector3 hitpoint;
    public KeyCode ShootKey = KeyCode.R;
    public float ShootForce = 0.3f;
    public Transform ShootPoint;
    public bool IsShooting = false;
    public float Timer = 0f;

    PlayerBulletPoolManager bulletManagers;

    // Use this for initialization
    void Start()
    {
        bulletManagers = FindObjectOfType<PlayerBulletPoolManager>();
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
           hitpoint = hit.point;
        }

        transform.DOLookAt(hitpoint, 0.2f);


        if (Input.GetKey(ShootKey) && IsShooting == false)
        {
            transform.DOLookAt(new Vector3(0,1),01);// scrivere meglio la direzione
            Shoot();
            IsShooting = true;

        }
        if (IsShooting == true)
        {

            Timer = Timer + Time.deltaTime;
        }
        if (Timer >= 0.3f)
        {
            IsShooting = false;
            Timer = 0f;
        }
        
    }

    public void Shoot()
    {
        PlayerBullet bulletToShoot = bulletManagers.GetBullet();
        bulletToShoot.transform.position = ShootPoint.position;
        bulletToShoot.Shoot(transform.forward, ShootForce);
        bulletToShoot.OnDestroy += OnBulletDestroy;
    }

    public void OnBulletDestroy(PlayerBullet bullet)
    {

        bullet.OnDestroy -= OnBulletDestroy;

    }
}

