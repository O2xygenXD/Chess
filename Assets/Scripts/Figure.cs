using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    public int CurrentX { set; get; }
    public int CurrentY { set; get; }
    public bool isWhite { set; get; }


    public void SetPosition(int x, int y)
    {
        
    }

    public virtual bool PossibleMove(int x, int y)
    {
        return true;
    }
}
