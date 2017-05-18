using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace GnomeCarArena
{
    public enum BodyType
    {
        Classic,
        Tall,
        Ship,
        Compact
    }

    public class BodyInfo
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
            Time.timeScale = 0.3f;
        }
    }
}

