using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    Vector2 StartPoint = new Vector2(0,-4);
    Vector2 EndPoint = new Vector2(0, 4);
    Vector2 Row = new Vector2(8,-4);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        for (int x = 0; x < 9; x++)
        {
            Gizmos.color = Color.red;
            Vector2 HGap = new Vector2(x, 0);
            Vector2 VGap = new Vector2(0, x);
            Gizmos.DrawLine(StartPoint + HGap, EndPoint + HGap);
            Gizmos.DrawLine(StartPoint + VGap, Row + VGap);
            //Gizmos.DrawLine(EndPoint, TRCorner);
        }    
    }

}
