using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchButtonScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _backgroundColour;
    [SerializeField] private Image _darkIcon;
    public bool LightTheme = false;
    private bool _animationToLow = false;
    private bool _animationToHight = false;
    private void FixedUpdate()
    {
        Colour(0.8f);
    }
    public void OnClick()
    {
        if(LightTheme)
        {
            _animationToHight=true;
        }
        else
        {
            _animationToLow=true;
        }
    }
   void Colour(float LightColourOnG)
    {
        if (_animationToLow)
        {
            if (_backgroundColour.color.g > 1- LightColourOnG)
            {
                _backgroundColour.color -= new Color(0.00392156862f * 2, 0.00392156862f * 2, 0.00392156862f * 2, 0);
                _darkIcon.color += new Color(0.0049999999905f, 0.0049999999905f, 0.0049999999905f, 0);
            }
            else
            {
                _animationToLow = false;
                LightTheme = true;
            }
        }
        else if (_animationToHight)
        {
            if (_backgroundColour.color.g < LightColourOnG)
            {
                _backgroundColour.color += new Color(0.00392156862f *2, 0.00392156862f * 2, 0.00392156862f * 2, 0);
                
                _darkIcon.color -= new Color(0.0049999999905f, 0.0049999999905f, 0.0049999999905f, 0);
            }
            else
            {
                _animationToHight = false;
                LightTheme = false;
            }
        }
    }
}
