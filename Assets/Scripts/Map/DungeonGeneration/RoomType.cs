using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum RoomType
    {
        LOBBY = 0,
        PLAYER_SPAWN = 1,
        NORMAL_ROOM = 2,
        BOSS_ROOM = 3,
        TREASURE_ROOM,
    }

public static class RoomTypeHelper
{
    public static List<RoomType> GetSpecialRoomTypes()
    {
        List<RoomType> specialRoomTypes = new List<RoomType>();


        foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
        {
            if ((int)roomType > 3)
            {
                specialRoomTypes.Add(roomType);
            }

        }

        return specialRoomTypes;
    }

}