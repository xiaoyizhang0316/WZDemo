using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenu : MonoBehaviour
{


    public Building[] buildingList;

    public void Show(Building[] list)
    {
        buildingList = list;
        FindObjectsOfType<Building>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
