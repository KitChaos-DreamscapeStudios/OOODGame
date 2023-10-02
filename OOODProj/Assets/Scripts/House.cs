using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public enum HouseSize{
        Apartment,
        Small,
        Medium,
        Large,
        Establishment

    }
    public HouseSize MySize;
    public List<Room.RoomType> RequiredRooms;
    public int NumberOfRooms;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
