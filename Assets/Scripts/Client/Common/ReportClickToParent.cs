using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportClickToParent : MonoBehaviour
{
    // Update is called once per frame
    void OnMouseDown()
    {
        SendMessageUpwards("OnChildMouseDown");
    }
}
