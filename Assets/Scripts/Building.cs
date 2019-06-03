using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Building")]
public class Building : ScriptableObject
{
    [SerializeField] string buildingName;

    [SerializeField] Building[] upstreamResource;
    [SerializeField] Building[] downStreamResource;
    [SerializeField] Color buildingColor;

    public string GetBuildingName()
    {
        return buildingName;
    }

    public Color GetBuildingColor()
    {
        return buildingColor;
    }

    public Building[] GetUpstreamResource()
    {
        return upstreamResource;
    }

    public Building[] GetDownstreamResource()
    {
        return downStreamResource;
    }

}
