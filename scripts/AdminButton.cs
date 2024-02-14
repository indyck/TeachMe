using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminButton : MonoBehaviour,ISwap
{
    [SerializeField]private Transform[] _slides;
    [SerializeField] private Transform[] _slidesToDown;
    public void OnClick()
    {
        ISwap.SlideGet(_slides[0]);
        ISwap.SwapDown(_slidesToDown);
    }
}
