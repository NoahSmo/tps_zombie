using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun Data", menuName = "Weapons/Gun Data")]
public class GunData : ScriptableObject
{
    public string gunName;
    public int damage;
    
    public float fireRate;
    public float reloadTime;
    
    public int magazineSize;
    public int maxAmmo;
    
    public float bulletSpeed;
    public float bulletSpread;
    public float bulletRange;
    public float bulletDrop;
}
