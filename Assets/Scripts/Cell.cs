using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    Material oldMat;
    public Material newMat;
    Vector3 c_midOfTop;
    Collider c_collider;
    Figure figure;
    

    void Start()
    {
        oldMat = GetComponent<Renderer>().material;
    }
    void Update()
    {
       
    }
    public void OnMouseEnter()
    {
        setNewColor();
    }
    public void OnMouseExit()
    {
        setOldColor();
    }
    public void setNewColor()
    {
        GetComponent<Renderer>().material = newMat;
    }
    void setOldColor()
    {
        GetComponent<Renderer>().material = oldMat;
    }
}
