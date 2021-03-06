﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : PickUpItems {

    public override void OnPickup(Collider collider)
    {
        base.OnPickup(collider);

        WeaponHandler wph = collider.GetComponent<WeaponHandler>();
        Weapon wp =gameObject.GetComponent<Weapon>();
        if(wph && wp)
        {
            if (wph.weaponList.Contains(wp))
            {
                 return;
            }

            //否则
            //防止再次触发拾取
            gameObject.GetComponent<SphereCollider>().enabled =false;
            wph.AddWeaponToList(wp);
            if(wph.currentWeapon ==null)
            {
                wph.currentWeapon = wp;
            }
        }




    }

}
