using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCamera : MonoBehaviour
{

    float mainSpeed = 50.0f;
    float shiftAdd = 250.0f;
    float maxShift = 1000.0f;
    float camSens = 0.25f;
    private Vector3 lastMouse = new Vector3(255, 255, 255);
    private float totalRun = 1.0f;

    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float xAngle;
    float yAngle;
    float xAngleTemp;
    float yAngleTemp;

    public GameObject panel;
    public GameObject text;

    void Start()
    {
        xAngle = 0;
        yAngle = 0;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
    }

    void Update()
    {
        //text.GetComponent<UnityEngine.UI.Text>().text = (Input.touchCount).ToString();
        
        //if (Input.touchCount > 0)
        //{
        //    if (Input.GetTouch(0).phase == TouchPhase.Began)
        //    {
        //        FirstPoint = Input.GetTouch(0).position;
        //        xAngleTemp = xAngle;
        //        yAngleTemp = yAngle;
        //    }
        //    if (Input.GetTouch(0).phase == TouchPhase.Moved)
        //    {
        //        SecondPoint = Input.GetTouch(0).position;
        //        xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
        //        yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
        //        this.transform.rotation = Quaternion.Euler(yAngle, -xAngle, 0.0f);
        //    }
        //}
    }
}
