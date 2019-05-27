using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land : MonoBehaviour
{

    [SerializeField] private string landId;
    [SerializeField] private Building[] availableBuilding;
    private Building landBuilding;


    public string GetLandId()
    {
        return landId;
    }


    public Building[] GetAvailbleBuilding()
    {
        return availableBuilding;
    }

    public void setLandBuilding(Building building)
    {
        landBuilding = building;
    }


    public Building getLandBuilding()
    {
        return landBuilding;
    }



    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<Text>().text = GetLandId();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
