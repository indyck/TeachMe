using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouAreTeacher : MonoBehaviour,ISwap
{
    [SerializeField] private Transform[] _slidesToDown;
    [SerializeField] private Transform[] _slidesToGet;
    public void OnCLick()
    {
        ISwap.Swap(_slidesToGet);
        ISwap.SwapDown(_slidesToDown);
        YouAreStudent.IsTeacher = true;
    }
}
