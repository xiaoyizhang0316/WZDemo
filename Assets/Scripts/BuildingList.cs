using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingList : MonoBehaviour
{


    [SerializeField] BuildingMenu[] buildingList;
    bool state;
    Otherland targetLand;

    public void SetTargetLand(Otherland land)
    {
        targetLand = land;
    }

    public Otherland GetTargetLand()
    {
        return targetLand;
    }

    public BuildingMenu[] GetBuildingList()
    {
        return buildingList;
    }

    public void ToggleShow()
    {
        gameObject.SetActive(!state);
        state = !state;
    }

    public void CheckOtherLandAvailability(Otherland land)
    {
        SetTargetLand(land);

        if ( targetLand.landBuilding == null)
        {
            int length = buildingList.Length;
            gameObject.SetActive(true);
            for (int i = 0; i < buildingList.Length; i++)
                buildingList[i].gameObject.SetActive(false);
            for (int i = 0; i < length; i++)
            {
                if (System.Array.IndexOf(targetLand.availableBuilding, buildingList[i].GetBuilding()) >= 0)
                    buildingList[i].gameObject.SetActive(true);
            }
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        state = false;
        gameObject.SetActive(state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
