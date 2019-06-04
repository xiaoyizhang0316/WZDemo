using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Otherland : MonoBehaviour
{

    [SerializeField] public Building landBuilding;
    [SerializeField] public GameObject buildingList;
    [SerializeField] public Building[] availableBuilding;
    public bool players;

    public void ShowUpstreamDownstream()
    {
        PlayerLand[] tempPlayerLand = FindObjectsOfType<PlayerLand>();
        Otherland[] tempOtherLand = FindObjectsOfType<Otherland>();
        for (int i = 0; i < tempPlayerLand.Length; i++)
            tempPlayerLand[i].GetComponent<Image>().color = tempPlayerLand[i].playerBuilding.GetBuildingColor();
        for (int i = 0; i < tempOtherLand.Length; i++)
        {
            if (tempOtherLand[i].landBuilding != null)
            {
                if(tempOtherLand[i].players)
                    tempOtherLand[i].GetComponentInChildren<Image>().color = tempOtherLand[i].landBuilding.GetBuildingColor();
                else
                {
                    tempOtherLand[i].GetComponentInChildren<Image>().color = Color.white;
                    tempOtherLand[i].GetComponentInChildren<Text>().text = tempOtherLand[i].landBuilding.GetBuildingName();
                }

            }  
            else
            {
                tempOtherLand[i].GetComponentInChildren<Text>().text = "空地";
                tempOtherLand[i].GetComponentInChildren<Text>().color = Color.white;
                tempOtherLand[i].GetComponentInChildren<Image>().color = Color.black;
            }
        }
            
        for(int i = 0; i < tempPlayerLand.Length; i++)
        {
            if (tempPlayerLand[i].playerBuilding != null)
            {
                if (System.Array.IndexOf(tempPlayerLand[i].playerBuilding.GetDownstreamResource(), landBuilding) >= 0)
                {
                    tempPlayerLand[i].GetComponentInChildren<Image>().color = Color.green;
                }
            }
        }
        for (int i = 0; i < tempOtherLand.Length; i++)
        {
            if (tempOtherLand[i].landBuilding != null)
            {
                if (System.Array.IndexOf(tempOtherLand[i].landBuilding.GetDownstreamResource(), landBuilding) >= 0)
                {
                    tempOtherLand[i].GetComponentInChildren<Image>().color = Color.green;
                }
            }
        }
        if (players)
            GetComponentInChildren<Image>().color = landBuilding.GetBuildingColor();
    }



    // Start is called before the first frame update
    void Start()
    {
        players = false;
        if (landBuilding != null)
            GetComponentInChildren<Text>().text = landBuilding.GetBuildingName();
        else
        {
            GetComponentInChildren<Text>().text = "空地";
            GetComponentInChildren<Text>().color = Color.white;
            GetComponentInChildren<Image>().color = Color.black;
        }
            
        //gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
