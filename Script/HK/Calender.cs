using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.RainMaker;

public class Calender : MonoBehaviour {

    int current = 0;
    int min = 0;
    int max = 9;
    string state = "default";

    int[] arr = new int[8] { 2, 0, 2, 6, 0, 5, 1, 4 };

    public GameObject Stage3;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 정답 체크
    void Check()
    {
        Transform Round1 = Stage3.transform.Find("1Round");

        // 현재
        if ( arr[3] == 6 &&  
             arr[4] == 0 && 
             arr[5] == 5 &&
             arr[6] == 1 &&
             arr[7] == 4 &&
             state != "default" )
        {
            Round1.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/DefaltBG");

            if(state == "sea")
            {
                GameObject.Find("SoundManager").GetComponent<SoundManager>().BGM_NumberSet(301);
                GameObject.Find("SoundManager").GetComponent<SoundManager>().BGM_ListPlay();
            }

            state = "default";
            gameObject.SetActive(false);
            Round1.Find("Change").Find("Sea").gameObject.SetActive(false);
            GameObject.Find("Rain").GetComponent<RainScript2D>().RainFalse();
            Stage3.GetComponent<Stage3>().FlowerRain();

            Round1.Find("OtherCollider").gameObject.SetActive(false);
            Round1.Find("Collider").gameObject.SetActive(true);
            Round1.Find("TextObject").gameObject.SetActive(true);
            Round1.Find("ClickObject").gameObject.SetActive(true);
            Round1.Find("CalenderButton").gameObject.SetActive(true);
            Round1.Find("Change").Find("Garden").gameObject.SetActive(true);

            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_NumberSet(395);
            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_ListPlay();
            
        }

        // 바다
        else if ( arr[3] == 5 &&
                  arr[4] == 0 &&
                  arr[5] == 7 &&
                  arr[6] == 0 &&
                  arr[7] == 5 &&
                  state != "sea" )
        {
            if(state == "rain")
            {
                GameObject.Find("Rain").GetComponent<RainScript2D>().RainFalse();
            }

            state = "sea";
            gameObject.SetActive(false);
            Round1.Find("Change").Find("Sea").gameObject.SetActive(true);

            GameObject.Find("Event_Manager").GetComponent<EventManager>().EventnumberSet(350);
            Round1.Find("TextObject").gameObject.SetActive(false);
            Round1.Find("ClickObject").gameObject.SetActive(false);
            Round1.Find("Collider").gameObject.SetActive(false);
            Round1.Find("OtherCollider").gameObject.SetActive(true);
            Round1.Find("Change").Find("Garden").gameObject.SetActive(false);

            if (Stage3.GetComponent<Stage3>().SunsetChk)
            {
                Round1.Find("Change").Find("Sea").Find("NotSunsetButton").gameObject.SetActive(false);
                Round1.Find("CalenderButton").gameObject.SetActive(true);
            }
            else if(!Stage3.GetComponent<Stage3>().SunsetChk)
            {
                Round1.Find("Change").Find("Sea").Find("NotSunsetButton").gameObject.SetActive(true);
                Round1.Find("CalenderButton").gameObject.SetActive(false);      
            }

            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_NumberSet(395);
            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_ListPlay();
            GameObject.Find("SoundManager").GetComponent<SoundManager>().BGM_NumberSet(304);
            GameObject.Find("SoundManager").GetComponent<SoundManager>().BGM_ListPlay();
        }

        // 비
        else if ( arr[3] == 5 &&
                  arr[4] == 0 &&
                  arr[5] == 8 &&
                  arr[6] == 2 &&
                  arr[7] == 9 &&
                  state != "rain" )
        {
            if (state == "sea")
            {
                GameObject.Find("SoundManager").GetComponent<SoundManager>().BGM_NumberSet(301);
                GameObject.Find("SoundManager").GetComponent<SoundManager>().BGM_ListPlay();
                Round1.Find("Change").Find("Sea").gameObject.SetActive(false);
                Round1.Find("Change").Find("Garden").gameObject.SetActive(true);
            }

            state = "rain";
            gameObject.SetActive(false);
            Round1.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/RainBG");

            GameObject.Find("Rain").GetComponent<RainScript2D>().RainTrue();
            Round1.Find("TextObject").gameObject.SetActive(false);
            Round1.Find("ClickObject").gameObject.SetActive(false);
            Round1.Find("Collider").gameObject.SetActive(false);
            Round1.Find("OtherCollider").gameObject.SetActive(true);
            //Stage3.GetComponent<Stage3>().FlowerRain();

            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_NumberSet(395);
            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_ListPlay();
        }

        else if ( state == "default")
        {
            Round1.Find("Collider").gameObject.SetActive(true);
            Round1.Find("OtherCollider").gameObject.SetActive(false);
            Round1.Find("TextObject").gameObject.SetActive(true);
            Round1.Find("ClickObject").gameObject.SetActive(true);
            Round1.Find("CalenderButton").gameObject.SetActive(true);
        }
    }

    // 각 자리마다 Max, Min을 다르게하고 Current를 불러옴
    void MaxNum(string str)
    {
        switch(str)
        {
            case "Year1":
                break;
            case "Year2":
                break;
            case "Year3":
                break;
            case "Year4":
                current = arr[3];
                min = 5;
                max = 6;
                break;

            case "Month1":
                current = arr[4];
                min = 0;
                max = 1;
                break;
            case "Month2":
                current = arr[5];
                min = 0;
                max = 9;
                break;

            case "Day1":
                current = arr[6];
                min = 0;
                max = 3;
                break;
            case "Day2":
                current = arr[7];
                min = 0;
                max = 9;
                break;

            default:
                current = 0;
                min = 0;
                max = 0;
                break;

        }
    }

    void SaveNum(string str)
    {
        switch (str)
        {
            case "Year1":
                break;
            case "Year2":
                break;
            case "Year3":
                break;
            case "Year4":
                arr[3] = current;
                break;

            case "Month1":
                arr[4] = current;
                break;
            case "Month2":
                arr[5] = current;
                break;

            case "Day1":
                arr[6] = current;
                break;
            case "Day2":
                arr[7] = current;
                break;

            default:
                break;

        }
    }

    // 이미지 변경
    void ChangeImage(string str)
    {
        //Sprite obj = transform.Find("Number").Find(str).gameObject.GetComponent<Image>().sprite;
        GameObject obj = transform.Find("Number").Find(str).gameObject;

        switch (current)
        {
            case 0:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/0");
                break;

            case 1:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/1");
                break;

            case 2:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/2");
                break;

            case 3:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/3");
                break;

            case 4:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/4");
                break;

            case 5:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/5");
                break;

            case 6:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/6");
                break;

            case 7:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/7");
                break;

            case 8:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/8");
                break;

            case 9:
                obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3Stage/Calender/9");
                break;

            default:
                break;
            
        }
    }

    public void NumUp(string name)
    {
        MaxNum(name);

        if (current < max)
            current++;

        else if (current == max)
            current = min;

        ChangeImage(name);
        SaveNum(name);
        Check();

    }
}

