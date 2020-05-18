using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int objectSlot1 = 0; //Futuro objeto 1
    public int objectSlot2 = 0; //Futuro objeto 2
    public int objectSlot3 = 0; //Futuro objeto 3
    [Serializable] 
        private int blood = 0;
        private int bones = 0;
        private int leathers = 0;
        private int resources = 0; 
}
