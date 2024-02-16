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
            slides[i].position = new Vector3(0, slides[i].position.y, slides[i].position.z);
        }
    }
    public static void SlideDel(Transform slide)
    {
        slide.position = new Vector3(20, slide.position.y, slide.position.z);
    }
    public static void SwapDown(Transform[] slides)
    {
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].position = new Vector3(20, slides[i].position.y, slides[i].position.z);
        }
    }
    public static void SlideGet(Transform slide)
    {
        slide.position = new Vector3(0, slide.position.y, slide.position.z);
    }
}
public class RegisterScript : MonoBehaviour, ISwap
{
    // Start is called before the first frame 
    [SerializeField]private InputField[] _textInputs;
    [SerializeField] private Transform[] _slides;
    [SerializeField] private Transform[] _slidesToDown;
    public static string Name;
    public static string Surname;
    public static string Password;
    private void Start()
    {
        
        Name = "Negr";
        Surname = "Negrovich";
        Password = "0090";
    }
    public void OnEndOfEnter()
    {
        foreach (InputField i in _textInputs)
        {
            i.GetComponent<InputField>();
        }
        try
        {
            Name = _textInputs[0].text;
            Surname = _textInputs[1].text;
            Password = _textInputs[2].text;
        }
        catch { }
        if (OnClickEnterText.InEnter)
        {
            //if аккаунт есть:
            ISwap.Swap(_slides);
            ISwap.SwapDown(_slidesToDown);
            //if аккаунта нет:
        }
        else
        {
            
            //if аккаунта нет:
            ISwap.Swap(_slides);
            ISwap.SwapDown(_slidesToDown);
            //if такой аккаунт есть:
        }
    }
}
