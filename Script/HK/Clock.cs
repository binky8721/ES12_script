using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {

    int num = 0;
    int max = 5;

    int first = 0;
    int second = 0;
    int third = 0;
    int fourth = 0;

    public Item item;
    public GameObject Stage3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void NumCheck()
    {
        if (first == 5 && second == 1 && third == 3 && fourth == 2)
        {
            this.gameObject.SetActive(false);

            Transform BG = Stage3.transform.Find("3Round").Find("BG");
            gameObject.SetActive(false);
            BG.Find("ClickObject").Find("Drawer(lock)").gameObject.SetActive(false);
            BG.Find("ClickObject").Find("Drawer(open)").gameObject.SetActive(true);

            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_Number = 395;
            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_ListPlay();

        }
    }


    void ImageChange(string str)
    {
        GameObject obj = transform.Find(str).Find("Text").gameObject;

        switch(num)
        {
            case 0:
                obj.GetComponent<Text>().text = "0";
                //obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("0");
                break;

            case 1:
                obj.GetComponent<Text>().text = "1";
                //obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("1");
                break;

            case 2:
                obj.GetComponent<Text>().text = "2";
                //obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("2");
                break;

            case 3:
                obj.GetComponent<Text>().text = "3";
                //obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("3");
                break;

            case 4:
                obj.GetComponent<Text>().text = "4";
                //obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("4");
                break;

            case 5:
                obj.GetComponent<Text>().text = "5";
                //obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("5");
                break;

            default:
                break;
        }
    }

    void SaveNum(string str)
    {
        switch(str)
        {
            case "1st":
                first = num;
                break;

            case "2nd":
                second = num;
                break;

            case "3rd":
                third = num;
                break;

            case "4th":
                fourth = num;
                break;

            default:
                break;

        }
    }

    void GetNum(string str)
    {
        switch (str)
        {
            case "1st":
                num = first;
                break;

            case "2nd":
                num = second;
                break;

            case "3rd":
                num = third;
                break;

            case "4th":
                num = fourth;
                break;

            default:
                break;

        }
    }

    public void NumUp(string name)
    {
        GetNum(name);
        if (num < max)
            num++;

        else if (num == max)
            num = 0;
       

        ImageChange(name);
        SaveNum(name);
        NumCheck();

    }

    public void NumDown(string name)
    {
        GetNum(name);
        if (num > 0)
            num--;

        else if (num == 0)
            num = max;

        ImageChange(name);
        SaveNum(name);
        NumCheck();
    }
}


