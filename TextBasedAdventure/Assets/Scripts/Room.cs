﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/Room")]
//Create Asset instable menu
public class Room : ScriptableObject
{
    [TextArea]
    public string description;
    public string roomName;
    public Exit[] exits;
    public InteractableObject[] interactableObjectsInRoom;
}
