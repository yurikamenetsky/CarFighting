using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GnomeCarArena
{
    public enum WeaponType
    {
        Rocket,
        Laser,
        DrillBig,
        DrillSmall,
        Rotator,
        RotatorInverse,
        Flame
    }

    public class WeaponInfo
    {
        public WeaponType weaponType;
        public float energy;
        public float dps;
    }

    public class Weapon : MonoBehaviour
    {
        WeaponInfo info;

        public float Dps { get { return info.dps; } }

        public Weapon(WeaponInfo info)
        {
            this.info = info;
        }     
    }
}
