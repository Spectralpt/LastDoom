using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    [SerializeField]
    private bool hasPistol;
    private bool isPistolEquiped;
    [SerializeField]
    private bool hasShotgun;
    private bool isShotgunEquiped;
    
    public Animator gun;
    
    private static readonly int IsShooting = Animator.StringToHash("isShooting");
    private static readonly int Shot = Animator.StringToHash("shot");
    
    //Ammo counts
    private int pistolAmmo;
    public float PistolAmmo => pistolAmmo;
    private int shotGunAmmo;
    public float ShotgunAmmo => shotGunAmmo;

    private void Start()
    {
        // Set starting weapon ammo
        shotGunAmmo = 50;
    }

    private void Update()
    {
         gun.SetBool(IsShooting, Input.GetMouseButton(0));
    }

    private void SpendAmmo()
    {
        if (isPistolEquiped && pistolAmmo > 0)
        {
            pistolAmmo -= 1;
        }
    }
}