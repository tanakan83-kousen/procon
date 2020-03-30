using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drago : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector3 objectpointScreen = Camera.main.WorldToScreenPoint(this.transform.position);
        Vector3 mousepointScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectpointScreen.z);
        Vector3 mousepointWorld = Camera.main.ScreenToWorldPoint(mousepointScreen);
        mousepointWorld.z = this.transform.position.z;
        this.transform.position = mousepointWorld;
    }
}
