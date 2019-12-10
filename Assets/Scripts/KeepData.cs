using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static float slider;
    public  static string speed;
    public static int time;
    public static string PlayerName;
    public static int PlayerScore;
    public static string PlayerSize;



    public Dropdown PlayerTime;
    public Slider PlayerSlider;
    public Dropdown PlayerSpeed;
    public InputField PlayerNameInput;
   // public Dropdown PlayerSizeUpdate;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void sliderValue()
    {
        slider = PlayerSlider.value;
    }

    public void speedValue()
    {
        switch (PlayerSpeed.value)
        {
            case 1:
                speed = "slow";
                break;

            case 2:
                speed = "fast";
                break;

            default:
                speed = "Normal";
                break;
        }
        // speed = PlayerSpeed.value.ToString();
    }

    public void timeValue()
    {
        switch (PlayerTime.value)
        {
            case 1:
                time = 20;
                break;

            case 2:
               time = 40;
                break;

            default:
                time = 00;
                break;
        }
        //time = PlayerTime.value;
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    /*public void UpdateScore()
    {
        PlayerScore = ScoreKeeper.thescore;
    }
    public void UpdateSize()
    {

        PlayerSize = PlayerSizeUpdate.value.ToString();
    }*/

}
