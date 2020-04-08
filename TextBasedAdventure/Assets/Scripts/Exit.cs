using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//lets you embed a class with sub properties in the inspector
//Use to display variables in the inspector similar to how a Vector3 shows up in the inspector.  
public class Exit 
{
    public string keyString;
    public string exitDescription;
    public Room valueRoom;
}
