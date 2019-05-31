using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Building")]
public class Building : ScriptableObject
{
    [SerializeField] string buildingName;

    [SerializeField] Building[] upstreamResource;
    [SerializeField] Building[] downStreamResource;

    public string GetBuildingName()
    {
        return buildingName;
    }


}
