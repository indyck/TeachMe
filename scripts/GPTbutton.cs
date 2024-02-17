using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class GPT : MonoBehaviour, ISwap
{
    [SerializeField] private Transform[] _slidesToDown;
    [SerializeField] private Transform _slide;
    [SerializeField] private Transform _teacherInterface;
    public bool IsClick;
    public void OnClick(){
        if(IsClick){
            ISwap.SlideDel(_slide);
            ISwap.SlideGet(_teacherInterface);
            IsClick = false;
        }
        else{
            ISwap.SwapDown(_slidesToDown);
            ISwap.SlideGet(_slide);
            IsClick = true;
        }
    }  
    private void Start(){
        IsClick = false;
    }
  
}
