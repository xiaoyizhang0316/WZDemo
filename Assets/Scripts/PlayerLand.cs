using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLand : MonoBehaviour
{


    public Building playerBuilding;

    public void CheckAvailability()
    {
        Otherland[] tempLand = FindObjectsOfType<Otherland>();
        for (int i = 0; i < tempLand.Length; i++)
            tempLand[i].GetComponent<Image>().color = Color.white;

        for (int i = 0; i < tempLand.Length; i++)
        {
            if(tempLand[i].landBuilding != null)
            {

                if(System.Array.IndexOf(tempLand[i].landBuilding.GetUpstreamResource(),playerBuilding) >= 0)
                { 
                    tempLand[i].GetComponentInChildren<Image>().color = Color.red;
                }
                else if(System.Array.IndexOf(tempLand[i].landBuilding.GetDownstreamResource(), playerBuilding) >= 0)
                {
                    tempLand[i].GetComponentInChildren<Image>().color = Color.blue;
                }
            }
        }
    }


    public void SetPlayerBuilding(Building building)
    {
        playerBuilding = building;
    }

    public Building GetPlayerBuilding()
    {
        return playerBuilding;
    }

    // Start is called before the first frame update
    private void Awake()
    {

    }


    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
