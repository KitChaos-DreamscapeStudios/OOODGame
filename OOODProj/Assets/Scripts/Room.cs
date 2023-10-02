using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Room : MonoBehaviour
{
    public enum RoomType{
        Dining,
        Kitchen,
        Bedroom,
        BigBedroom,
        Den,
        Parlor

    }
    public RoomType MyType;

    // Start is called before the first frame update
    public abstract void CreateRoom();
    public abstract void CreateWalls();
}
