using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButton : MonoBehaviour,ISwap
{
    [SerializeField] private Transform _scrollView;
    [SerializeField] private Transform _slide;
    [SerializeField] private Text _text;
    public void OnClick()
    {
        ISwap.SlideDel(_scrollView);
        ISwap.SlideGet(_slide);
        _text.text = "Создание нового курса";
    }
}
