using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButton : MonoBehaviour,ISwap
{
    [SerializeField] private Transform _scrollView;
    [SerializeField] private Transform _slide;
    [SerializeField] private Transform _downPanel;
    [SerializeField] private Transform[] _slidesToDown;
    [SerializeField] public Text _text;
    public static bool _isClicked;
    public void OnClick()
    {
        if (_isClicked)
        {
            _isClicked = false;
            ISwap.SwapDown(_slidesToDown);
            ISwap.SlideDel(_slide);
            ISwap.SlideGet(_scrollView);
            ISwap.SlideGet(_downPanel);
            _text.text = "Доступные курсы";
        }
        else
        {
            _isClicked = true;
            ISwap.SwapDown(_slidesToDown);
            ISwap.SlideDel(_scrollView);
            ISwap.SlideDel(_downPanel);
            ISwap.SlideGet(_slide);
            _text.text = "Создание нового курса";
        }
        
    }
}
