using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GnomeCarArena
{
    public enum BodySlotType
    {
        Wheel,
        Weapon,
        Utility
    }

    public enum BodySlotLevel
    {
        Wood,
        Metal,
        Crystal
    }

    public class BodySlotInfo
    {
        public BodySlotType slotType;
        public BodySlotLevel slotLevel;
        public Vector3 position;
    }
    
    public class BodySlot : MonoBehaviour
    {
        [SerializeField]
        GameObject view;

        BodySlotInfo info;

        public void Init(BodySlotInfo info)
        {
            this.info = info;
        }
    }
}
