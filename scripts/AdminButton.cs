using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminButton : MonoBehaviour,ISwap
{
    [SerializeField]private Transform _slides;
    [SerializeField] private Transform[] _slidesToDown;
    public static bool _isClicked;
    [SerializeField] Text _text;
    
    public void OnClick()
    {
        Account._isClicked = false;
        if (AddButton._isClicked)
        {
            _text.text = "Доступные курсы";
            AddButton._isClicked = false;
        }
        if (_isClicked)
        {
            ISwap.SlideGet(_slidesToDown[0]);
            ISwap.SlideDel(_slides);
            _isClicked = false;
        }
        else
        {
            ISwap.SlideGet(_slides);
            ISwap.SwapDown(_slidesToDown);
            _isClicked = true;
        }
        
    }
}
