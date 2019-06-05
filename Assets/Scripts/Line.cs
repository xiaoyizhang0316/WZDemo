using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{


    private Vector2 v0;
    private Vector2 v1;

    public void SetPosition(Vector2 temp1,Vector2 temp2)
    {
        v0 = temp1;
        v1 = temp2;
    }

    public void GenerateLine()
    {
        GetComponentInChildren<LineRenderer>().SetPosition(0, v0);
        GetComponentInChildren<LineRenderer>().SetPosition(1, v1);
        GetComponentInChildren<LineRenderer>().positionCount = 2;
        GetComponentInChildren<LineRenderer>().startWidth = 0.1f;
        GetComponentInChildren<LineRenderer>().endWidth = 0.1f;
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
