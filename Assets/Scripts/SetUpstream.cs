using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUpstream : MonoBehaviour
{

    public Land targetLand;
    public UnityEngine.UI.Extensions.UILineRenderer lineRender;



    public void ResetColor()
    {
        Land[] tempLand = FindObjectsOfType<Land>();
        for (int i = 0; i < tempLand.Length; i++)
            if (tempLand[i].GetLandBuilding() != null)
                tempLand[i].GetComponent<Image>().color = tempLand[i].GetLandBuilding().GetBuildingColor();
    }

    public void ShowUpstream()
    {
        ResetColor();
        Land[] tempLand = FindObjectsOfType<Land>();
        for (int i = 0; i < tempLand.Length; i++)
        {
            if(tempLand[i].GetLandBuilding() != null)
            {
                if (System.Array.IndexOf(tempLand[i].GetLandBuilding().GetDownstreamResource(), targetLand.GetLandBuilding()) >= 0)
                {
                    tempLand[i].GetComponentInChildren<Image>().color = Color.red;
                    var point = new Vector2(targetLand.GetComponent<Transform>().position.x*160, targetLand.GetComponent<Transform>().position.y*160);
                    var point2 = new Vector2(tempLand[i].GetComponent<Transform>().position.x*160, tempLand[i].GetComponent<Transform>().position.y*160);
                    var pointList = new List<Vector2>(lineRender.Points);
                    pointList.Add(point);
                    pointList.Add(point2);
                    lineRender.Points = pointList.ToArray();
                }

            }

        }
       
    }


    public void ShowDownstream()
    {
        ResetColor();
        Land[] tempLand = FindObjectsOfType<Land>();
        for (int i = 0; i < tempLand.Length; i++)
        {
            if (tempLand[i].GetLandBuilding() != null)
            {
                if (System.Array.IndexOf(tempLand[i].GetLandBuilding().GetUpstreamResource(), targetLand.GetLandBuilding()) >= 0)
                    tempLand[i].GetComponentInChildren<Image>().color = Color.blue;
            }
        }

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
