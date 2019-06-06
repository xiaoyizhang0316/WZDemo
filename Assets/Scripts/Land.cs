using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land : MonoBehaviour
{
    private bool isSetUpstream;
    private bool isSetDownStream;
    [SerializeField] SetUpstream upstreamOption;
    [SerializeField] SetDownStream downstreamOption;
    [SerializeField] private string landId;
    [SerializeField] private Building[] availableBuilding;
    [SerializeField] public GameObject bigMapLand;
    private Building landBuilding;
    List<Line> buildingLine;

    public string GetLandId()
    {
        return landId; 
    }

    public void MakeLine()
    {
        Line tempLine = FindObjectOfType<Line>();
        Instantiate(tempLine);
        Vector2 temp1 = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y);
        Vector2 temp2 = new Vector2(GetComponent<Transform>().position.x - 1, GetComponent<Transform>().position.y - 1);
        tempLine.SetPosition(temp1,temp2);
        tempLine.GenerateLine();
        buildingLine.Add(tempLine);
    }

    public void SetUpstream()
    {
        upstreamOption.targetLand = this;

    }

    public Building[] GetAvailbleBuilding()
    {
        return availableBuilding;
    }

    public void SetLandBuilding(Building building)
    {
        landBuilding = building;
    }


    public Building GetLandBuilding()
    {
        return landBuilding;
    }



    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<Text>().text = GetLandId();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
