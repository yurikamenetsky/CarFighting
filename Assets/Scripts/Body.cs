using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace GnomeCarArena
{
    public enum ItemLevel
    {
        Wood,
        Metal,
        Crystal
    }
    
    public enum BodyType
    {
        Classic,
        Tall,
        Ship,
        Compact
    }

    public class ItemInfo
    {
        public ItemLevel level;
        public int quality;
    }

    public class BodyInfo : ItemInfo
    {
        public BodyType type;
        public List<BodySlotInfo> slots;
    }
    
    public class Body : MonoBehaviour
    {
        BodyInfo info;
        List<BodySlot> slots = new List<BodySlot>();

        void Awake()
        {
            Time.timeScale = 1f;
        }
    }
}

