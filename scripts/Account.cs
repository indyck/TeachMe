using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Account : MonoBehaviour,ISwap
{
    [SerializeField] private Transform _slide;
    [SerializeField] private Transform[] _slideToDown;
    public static bool _isClicked;
    [SerializeField] Text _text;
    Button _onClick;
    private void Start()
    {
        _onClick = GetComponent<Button>();
    }
    public void OnClick()
    {
        AdminButton._isClicked = false;
        if (AddButton._isClicked)
        {
            _text.text = "Доступные курсы";
            AddButton._isClicked = false;
        }
        if (_isClicked)
        {
            ISwap.SlideGet(_slideToDown[0]);
            ISwap.SlideDel(_slide);
            _isClicked = false;
        }
        else
        {
            ISwap.SlideGet(_slide);
            ISwap.SwapDown(_slideToDown);
            _isClicked = true;
        }
        
    }

}
