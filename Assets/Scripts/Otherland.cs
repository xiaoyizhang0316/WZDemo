using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Otherland : MonoBehaviour
{

    [SerializeField] public Building landBuilding;
    [SerializeField] public GameObject buildingMenu;

    public void ShowUpstreamDownstream()
    {
        PlayerLand[] tempPlayerLand = FindObjectsOfType<PlayerLand>();
        Otherland[] tempOtherLand = FindObjectsOfType<Otherland>();
        for (int i = 0; i < tempPlayerLand.Length; i++)
            tempPlayerLand[i].GetComponent<Image>().color = tempPlayerLand[i].playerBuilding.GetBuildingColor();
        for (int i = 0; i < tempOtherLand.Length; i++)
            tempOtherLand[i].GetComponent<Image>().color = Color.white;
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

    }


    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
