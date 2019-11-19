using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.RainMaker;
using UnityEngine.UI;

public class Stage3 : MonoBehaviour {

    Transform Round1;
    Transform Round2;
    Transform Round3;
	public EventManager Event;
	public Item item;
    public bool SunsetChk = false;
    public bool NecklaceChk = false;
    public bool Seed = false;
    public bool FlowerRingGet = false;

    // Use this for initialization
    void Start () {
        Round1 = transform.Find("1Round");
        Round2 = transform.Find("2Round");
        Round3 = transform.Find("3Round");
        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update () {
        //PlayerPrefs.DeleteAll();
    }


    public void FlowerRain()
    {
        if (Round1.Find("Image").gameObject.activeSelf && !FlowerRingGet)
        {
            if (Seed)
            {
                Transform Garden = Round1.Find("Change").Find("Garden");
                Garden.Find("Grass").gameObject.SetActive(false);
                Garden.Find("Flower").gameObject.SetActive(true);
                Event.EventnumberSet(300);
                GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_Number = 300;
                GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_ListPlay();

                // 이 코드를 쓰면 씨뿌리고 비오면 바로 꽃이되면서 대사창
                // 이 코드를 안 쓰면 씨뿌리고 비오면서 대사창 후 현재 버튼해서 돌아와야함->이벤트넘버로 수정가능
                // 중점은 꽃피는 대사에 빗소리가 들려야하는가? 아닌가?
                // GameObject.Find("Rain").GetComponent<RainScript2D>().RainFalse();
                
            }

            else
            {
                Transform Garden = Round1.Find("Change").Find("Garden");
                Garden.Find("Grass").gameObject.SetActive(true);
                Garden.Find("Flower").gameObject.SetActive(false);
            }
        }
    }

    public void SeaChk()
    {
        if (SunsetChk && NecklaceChk)
        {
            Round1.Find("Change").Find("Sea").Find("NotSunsetButton").gameObject.SetActive(false);
            Round1.Find("CalenderButton").gameObject.SetActive(true);
        }
    }

    public void MedicalCertificate()
    {
        GameObject Piece1 = Round2.Find("Medical").Find("Piece1").gameObject;
        GameObject Piece2 = Round2.Find("Medical").Find("Piece2").gameObject;
        GameObject Piece3 = Round2.Find("Medical").Find("Piece3").gameObject;
        GameObject Piece4 = Round2.Find("Medical").Find("Piece4").gameObject;
        GameObject Piece5 = Round2.Find("Medical").Find("Piece5").gameObject;

        if(Piece1.activeSelf && Piece2.activeSelf && Piece3.activeSelf && Piece4.activeSelf && Piece5.activeSelf)
        {
			Event.EventnumberSet (310);
        }
    }

	public void Orgel()
	{
		Transform orgel = Round3.Find ("Orgel");
		if(orgel.Find("Finish").gameObject.activeSelf && orgel.Find("Cover").gameObject.activeSelf)
		{
			// 음악 들리고
			// 재규어 잠듦
			// 아이템 얻는 거 이벤트 매니져로 변경하기
			Round3.Find("BG").Find("Jaguar").gameObject.SetActive(false);
            Round3.Find("BG").Find("JaguarSleep").gameObject.SetActive(true);
            Event.EventnumberSet (322);

			Round3.Find ("BG").Find ("TextObject").Find ("OrgelButton").gameObject.SetActive (false);
			Round3.Find ("BG").Find ("ClickObject").Find ("OrgelGet").gameObject.SetActive (true);

            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_Number = 322;
            GameObject.Find("SoundManager").GetComponent<SoundManager>().SE_ListPlay();

            //OpenDoor ();
            //item.GetNumber (19);
            //item.LoadJson ("3Stage");
        }
	}

	public void carrierChk()
	{
		GameObject Dreamcatcher = Round3.Find("Carrier").Find("Dreamcatcher").gameObject;
		GameObject Rose = Round3.Find("Carrier").Find("Rose").gameObject;
		GameObject Book = Round3.Find("Carrier").Find("Book").gameObject;
		GameObject Orgel = Round3.Find("Carrier").Find("Orgel").gameObject;
		GameObject Picture = Round3.Find("Carrier").Find("Picture").gameObject;

		if (Dreamcatcher.activeSelf && Rose.activeSelf && Book.activeSelf && Orgel.activeSelf && Picture.activeSelf) 
		{
			Round3.Find ("BG").Find ("TextObject").Find ("CarrierButton").gameObject.SetActive (false);
			Round3.Find ("BG").Find ("ClickObject").Find ("CarrierGet").gameObject.SetActive (true);
		}
	}

	public void OpenDoor()
	{
		if(!Round3.Find("BG").Find("ClickObject").Find("CarrierGet").gameObject.activeSelf)
		{
			Round3.Find ("BG").Find ("TextObject").Find ("Door").gameObject.SetActive (true);
		}
	}

}
