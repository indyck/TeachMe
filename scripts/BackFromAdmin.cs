using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackFromAdmin : MonoBehaviour,ISwap
{
    [SerializeField]Button _but;
    [SerializeField] private Transform[] _slides;
    public void OnClick()
    {
        ISwap.SlideGet(_slides[0]);
        ISwap.SlideDel(_slides[1]);
        
    }

}
