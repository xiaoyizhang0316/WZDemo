using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmMenu : MonoBehaviour
{


    Otherland targetLand;
    Building targetBuilding;

    public void Show(BuildingMenu menu)
    {
        targetLand = menu.GetComponentInParent<BuildingList>().GetTargetLand();
        targetBuilding = menu.GetBuilding();
        gameObject.SetActive(true);
    }

    public void Build()
    {
        targetLand.GetComponentInChildren<Text>().text = targetBuilding.GetBuildingName();
        targetLand.GetComponentInChildren<Image>().color = targetBuilding.GetBuildingColor();
        targetLand.landBuilding = targetBuilding;
        gameObject.SetActive(false);
        targetLand.players = true;
    }

    public void SetTarGetLand(Otherland land)
    {
        targetLand = land;
    }



    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
