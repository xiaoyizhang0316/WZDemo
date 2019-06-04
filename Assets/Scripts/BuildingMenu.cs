using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildingMenu : MonoBehaviour
{

    Gear[] gearList;
    Attachment[] attachmentList;
    [SerializeField] Building buildingName;
    Land targetLand;
    Otherland targetOtherLand;

    public void CheckAvailbility(Land land)
    {
        targetLand = land;
        int flag = 0;
        for (int i = 0;i < land.GetAvailbleBuilding().Length; i++)
        {
            if(buildingName == land.GetAvailbleBuilding()[i])
            {
                flag = 1;
            }
        }
        if (flag == 0)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);

        Debug.Log(targetLand);
    }

    public Building GetBuilding()
    {
        return buildingName;
    }

    public Land GetLand()
    {
        return targetLand;
    }

    public Otherland GetOtherland()
    {
        return targetOtherLand;
    }

    public void Build()
    {
        targetLand.GetComponentInChildren<Text>().text = buildingName.GetBuildingName();
        targetLand.GetComponentInChildren<Image>().color = buildingName.GetBuildingColor();
        targetLand.SetLandBuilding(buildingName);
        targetLand.bigMapLand.SetActive(true);
        targetLand.bigMapLand.GetComponentInChildren<Text>().text = buildingName.GetBuildingName();
        targetLand.bigMapLand.GetComponentInChildren<Image>().color = buildingName.GetBuildingColor();
        targetLand.bigMapLand.GetComponentInChildren<PlayerLand>().SetPlayerBuilding(buildingName);

    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<Text>().text = buildingName.GetBuildingName();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
