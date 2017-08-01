using UnityEngine;
using System.Collections.Generic;

public class ClickPositionList : MonoBehaviour {

    public Transform clickobject;
    public List<Vector3> CurrentMousePosition = new List<Vector3>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log(Input.mousePosition);
            Instantiate(clickobject, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), transform.rotation);
            CurrentMousePosition.Add(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)));
            for (int i = 0; i < CurrentMousePosition.Count; i++)
            {
                Debug.Log("currentmouse: " + CurrentMousePosition[i]);
            }
        }
	}
}
