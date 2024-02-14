using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

interface ISwap
{
    public static void Swap(Transform[] slides)
    {
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].position = new Vector2(0, slides[i].position.y);
        }
    }
    public static void SlideDel(Transform slide)
    {
        slide.position = new Vector2(20, slide.position.y);
    }
    public static void SwapDown(Transform[] slides)
    {
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].position = new Vector2(20, slides[i].position.y);
        }
    }
    public static void SlideGet(Transform slide)
    {
        slide.position = new Vector2(0, slide.position.y);
    }
}
public class RegisterScript : MonoBehaviour, ISwap
{
    // Start is called before the first frame 
    [SerializeField]private InputField[] _textInputs;
    [SerializeField] private Transform[] _slides;
    private void Start()
    {
        foreach(InputField i in _textInputs)
        {
            i.GetComponent<InputField>();
        }
    }
    public void OnEndOfEnter()
    {
        foreach(InputField i in _textInputs)
        {
            //проверка полей
        }
        if (OnClickEnterText.InEnter)
        {
            //if аккаунт есть:
            ISwap.SlideGet(_slides[1]);
            ISwap.SlideDel(_slides[0]);
            //if аккаунта нет:
        }
        else
        {
            //if аккаунта нет:
            ISwap.SlideGet(_slides[1]);
            ISwap.SlideDel(_slides[0]);
            //if такой аккаунт есть:
        }
    }
}
