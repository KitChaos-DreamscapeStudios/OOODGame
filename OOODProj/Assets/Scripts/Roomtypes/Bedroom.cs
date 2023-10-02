using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// A bedroom requires:
///     A bed,
///     A dresser of some kind,
///     At least one window and one light,
///and a bedroom will also be smaller in size, typically.
///     
/// </summary>
public class Bedroom : Room{
    
    
    public List<GameObject> BedOptions;
    public List<GameObject> WindowOptions;
    public List<GameObject> LightOptions;

    public List<GameObject> DresserOptions;//Also Includes Closets
    
    public override void CreateRoom()
    {
        var Rand = Random.Range(0, 100);

    }
    public override void CreateWalls()
    {
        throw new System.NotImplementedException();
    }
}