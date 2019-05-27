using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyBuilding : MonoBehaviour
{
    Land targetLand;

    public void CheckStatus(Land land)
    {
        targetLand = land;
        if (targetLand.getLandBuilding() != null)
            gameObject.SetActive(true);
        else
        gameObject.SetActive(false);

        Debug.Log(targetLand.getLandBuilding());

    }

    public void RunDestroy()
    {
        targetLand.setLandBuilding(null);
        targetLand.GetComponentInChildren<Text>().text = targetLand.GetLandId();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(targetLand)
            CheckStatus(targetLand);
    }


}
