using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildingMenu : MonoBehaviour
{


    [SerializeField] Building buildingName;
    Land targetLand;

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

    public void Build()
    {
        targetLand.GetComponentInChildren<Text>().text = buildingName.GetBuildingName();
        targetLand.setLandBuilding(buildingName);

    }

    public void Show()
    {
        Debug.Log('1');
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
