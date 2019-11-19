﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour {

    Hintgeteffect HF;

    public Image HintItemImage;
    public GameObject ButtonScrollList; //아이템 목록창
    public GameObject TextScrollArea;   //아이템 내용창

    public ScrollRect SR;

    [HideInInspector]
    public RectTransform CurrentTextContent;

    public Text CurrentItemNumberText;

    public Text SimpleNameText;

    public Text Brazil;
    public Text Mongoal;
    public Text test;

    public GameLoader GLHandler;
    // bool IsItemUnlock = false;
    [HideInInspector]
    public int SelectTextNumber = 0;


    //언락될 아이템 넘버
    public int ToUnlockTextNumber = 0;

    public GameObject HintText;


    //처음클릭용 힌트변수들
    public bool isFirstPlastercastClick = false;
    public bool isFirstSuitcaseClick = false;

    public struct HighlightText
    {
        public string HT_name;
        public string HT_filename;
        public bool IsUnlock;
        public HighlightText(string HT_name,string HT_filename,bool IsUnlock)
        {
            this.HT_name = HT_name;
            this.HT_filename = HT_filename;
            this.IsUnlock = IsUnlock;
        }
       
    }
    const int HightlightText_SIZE = 11;
    //강조 아이템 텍스트 구조체 배열 선언
    public HighlightText[] HT = new HighlightText[HightlightText_SIZE]
    {
        new HighlightText("??????","before_MachineManual",false),
        new HighlightText("??????","before_FathersLetter",false),
        new HighlightText("??????","before_DreamCatcherBluePrint",false),
        new HighlightText("??????","before_RoJalsLetter",false),
        new HighlightText("??????","before_clue_recipe",false),
        new HighlightText("??????","before_clue_stuff",false),
        new HighlightText("??????","before_clue_fairytale",false),
        new HighlightText("??????","before_clue_painting",false),
        new HighlightText("??????","before_clue_poems",false),
        new HighlightText("??????","before_clue_plastercast",false),
        new HighlightText("??????","before_clue_suitcase",false)
    };
    




	void Start ()
    {
        CurrentTextContent = Brazil.rectTransform;
        Brazil.gameObject.SetActive(true);
        SR.content = CurrentTextContent;
        
    }
	
	void Update ()
    {
        UpdateSR();
        ChangeText(); // 아이템 내용창 내용 업데이트

        OutputText(); //왼쪽에 띄울 텍스트 내용업데이트
    }



    //ScrollRect 업데이트 함수
    void UpdateSR()
    {
        SR.content = CurrentTextContent;

        //아이템 목록 볼때 오른쪽밑 아이템 이름 텍스트창 업데이트
        SimpleNameText.text = HT[SelectTextNumber].HT_name;
        /*
        if (!HT[SelectTextNumber].IsUnlock)
            SimpleNameText.text = "??????";
        else if (HT[SelectTextNumber].IsUnlock)
        {
            if (SelectTextNumber != 0)
                SimpleNameText.text = HT[SelectTextNumber].HT_name;
            else
                SimpleNameText.text = " ";
        }
        */


        //현재 아이템 넘버링 텍스트 업데이트
        CurrentItemNumberText.text = "Item No." + (SelectTextNumber+1);


        //아이템 아이콘 이미지 업데이트
        HintItemImage.sprite = Resources.Load<Sprite>("HintItem/"+HT[SelectTextNumber].HT_filename);
        
    }

    
    public void ChangeText()
    {
        //그전 텍스트 오브젝트를 false
        CurrentTextContent.gameObject.SetActive(false);
        switch (SelectTextNumber)
        {
            //전뇌기계 설명서(연구실 처음)
            case 0:
                CurrentTextContent = Brazil.rectTransform;
                CurrentTextContent.gameObject.SetActive(true);
                break;

            //아버지의 편지(브라질)
            case 1:
                CurrentTextContent = Brazil.rectTransform;
                CurrentTextContent.gameObject.SetActive(true);
                break;
            //로잘린의 편지(몽골)
            case 2:
                CurrentTextContent = Mongoal.rectTransform;
                CurrentTextContent.gameObject.SetActive(true);
                break;
            //드림캐처 설계도
            case 3:
                CurrentTextContent = test.rectTransform;
                CurrentTextContent.gameObject.SetActive(true);
                break;
        }
        
    }

    //현재 선택되있는 아이템 넘버링 세팅
    public void SelectTextNumberSet(int num)
    {
        SelectTextNumber = num;
    }

    //아이템 내용창 띄우기
    public void EnterItemContentText()
    {
        //Text SelectHighlightText = CurrentTextContent

        //만약 인덱스 번호가 x이고 Unlock이 되었을때
        switch (SelectTextNumber)
        {
            //전뇌기계 설명서(연구실 처음)
            case 0:
                if (HT[SelectTextNumber].IsUnlock)
                {
                    TextScrollArea.SetActive(true);
                    ButtonScrollList.SetActive(false);
                }
                break;

            //아버지편지(브라질)
            case 1:
                //아이템이 Unlock이 되었다면
                if (HT[SelectTextNumber].IsUnlock)
                {
                    TextScrollArea.SetActive(true);
                    ButtonScrollList.SetActive(false);
                }
                break;
            //드림캐쳐 설계도
            case 2:
                if (HT[SelectTextNumber].IsUnlock)
                {
                    TextScrollArea.SetActive(true);
                    ButtonScrollList.SetActive(false);
                }
                break;
            //로잘린편지(몽골)
            case 3:
                if (HT[SelectTextNumber].IsUnlock)
                {
                    TextScrollArea.SetActive(true);
                    ButtonScrollList.SetActive(false);
                }
                break;
            //허르헉레시피(몽골)
            case 4:
                if (HT[SelectTextNumber].IsUnlock)
                {
                    TextScrollArea.SetActive(true);
                    ButtonScrollList.SetActive(false);
                }
                break;

        }
        

        //x번째 아이템창 버튼을 Highlight상태로 해준다 (Event trigger로 구현했는데 수정필요)
        //추가로 Highlight 컬러 설정도 해주기(추가예정)

        //하이라이트 상태일때 Enter키를 누르면 바로 그아이템 설명 텍스트 창으로 이동가능(추가예정)

        //
    }

    public void ExitItemContentText()
    {
        ButtonScrollList.SetActive(true);
        TextScrollArea.SetActive(false);
    }


    //언락넘버 설정 후 언락
    public void ToUnlockTextNumberSet(int num)
    {
        ToUnlockTextNumber = num;
        ItemUnlock();
    }
    //아이템 언락시 실행함수
    void ItemUnlock()
    {
        switch(ToUnlockTextNumber)
        {
            case 0:
                HT[0].HT_name = "전뇌기계 설명서";
                HT[0].HT_filename = "MachineManual";
                HT[0].IsUnlock = true;
                SelectTextNumber = 0;
                //Lock Text를 setactive(false) 시키고
                //ItemName Text를 Setactive(true) 시킨다
                break;
            case 1:
                HT[1].HT_name = "아버지의 편지(브라질)";
                HT[1].HT_filename = "FathersLetter";
                HT[1].IsUnlock = true;
                SelectTextNumber = 1;
                break;
            case 2:
                HT[2].HT_name = "드림캐쳐설계도";
                HT[2].HT_filename = "DreamCatcherBluePrint";
                HT[2].IsUnlock = true;
                SelectTextNumber = 2;
                break;
            case 3:
                HT[3].HT_name = "로잘린의 편지(몽골)";
                HT[3].HT_filename = "RoJalsLetter";
                HT[3].IsUnlock = true;
                SelectTextNumber = 3;
                break;
            case 4:
                HT[4].HT_name = "허르헉레시피";
                HT[4].HT_filename = "clue_recipe";
                HT[4].IsUnlock = true;
                SelectTextNumber = 4;
                break;
            case 5:
                HT[5].HT_name = "박제";
                HT[5].HT_filename = "clue_stuff";
                HT[5].IsUnlock = true;
                SelectTextNumber = 5;
                break;
            case 6:
                HT[6].HT_name = "아버지의 동화책";
                HT[6].HT_filename = "clue_fairytale";
                HT[6].IsUnlock = true;
                SelectTextNumber = 6;
                break;
            case 7:
                HT[7].HT_name = "가려진 그림";
                HT[7].HT_filename = "clue_painting";
                HT[7].IsUnlock = true;
                SelectTextNumber = 7;
                break;
            case 8:
                HT[8].HT_name = "낡은 공책";
                HT[8].HT_filename = "clue_poems";
                HT[8].IsUnlock = true;
                SelectTextNumber = 8;
                break;
            case 9:
                HT[9].HT_name = "조각상";
                HT[9].HT_filename = "clue_plastercast";
                HT[9].IsUnlock = true;
                SelectTextNumber = 9;
                break;
            case 10:
                HT[10].HT_name = "캐리어";
                HT[10].HT_filename = "clue_suitcase";
                HT[10].IsUnlock = true;
                SelectTextNumber = 10;
                break;
        }
    }

    public void OutputText()
    {
        //HintText에있는 모든 자식 오브젝트 들을 받아옴
        Component[] trSphereList = HintText.gameObject.GetComponentsInChildren<Component>();
        //받아와서 일단 모든 자식 오브젝트를 꺼줌
        for (int i = 0; i < trSphereList.Length; i++)
        {
            if (trSphereList[i].transform.parent == HintText.transform)
                trSphereList[i].gameObject.SetActive(false);
        }


        //그 후 선택된 오브젝트 텍스트만 활성화 시켜서 띄움
        switch (SelectTextNumber)
        {
            case 0:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("0_MachineManual").gameObject.SetActive(true);
                break;

            case 1:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("1_Brazilletter").gameObject.SetActive(true);
                break;
            case 2:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("2_DreamCatcherBluePrint").gameObject.SetActive(true);
                break;
            case 3:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("3_Mongoalletter").gameObject.SetActive(true);
                break;
            case 4:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("4_recipe").gameObject.SetActive(true);
                break;
            case 5:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("5_stuff").gameObject.SetActive(true);
                break;
            case 6:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("6_fairytale").gameObject.SetActive(true);
                break;
            case 7:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("7_painting").gameObject.SetActive(true);
                break;
            case 8:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("8_poems").gameObject.SetActive(true);
                break;
            case 9:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("9_plastercast").gameObject.SetActive(true);
                break;
            case 10:
                if (HT[SelectTextNumber].IsUnlock)
                    HintText.transform.Find("10_suitcase").gameObject.SetActive(true);
                break;
        }
    }

    public void NextHint()
    {
        if (SelectTextNumber == 10) //숫자넘김 에러방지용
            return;

        //여기 if문의 숫자는 힌트의 총개수에 따라 나중에 바꿔줘야됨
        if (SelectTextNumber<11)
            SelectTextNumber++;
    }
    public void BeforeHint()
    {
        if(SelectTextNumber>0)
            SelectTextNumber--;
    }


    //처음 한번 클릭했을시만 힌트얻는 함수들..//
    public void firstclick_Plastercast()
    {
        if (isFirstPlastercastClick == false)
        {
            //힌트이펙트 재생
            GameObject.Find("4_HintEnter").GetComponent<Hintgeteffect>().Starthinteffect();
            GameObject.Find("HintTextManager").GetComponent<TextChange>().ToUnlockTextNumberSet(9);
            isFirstPlastercastClick = true;
        }

    }
    public void firstclick_Suitcase()
    {
        if (isFirstSuitcaseClick == false)
        {
            //힌트이펙트 재생
            GameObject.Find("4_HintEnter").GetComponent<Hintgeteffect>().Starthinteffect();
            GameObject.Find("HintTextManager").GetComponent<TextChange>().ToUnlockTextNumberSet(10);
            isFirstSuitcaseClick = true;
        }
    }

    //로드를 위한 함수
    public void LoadHint(int stageinfo)
    {
        switch(stageinfo)
        {
            case 0:
                break;
            case 1:
                ToUnlockTextNumberSet(0);
                ToUnlockTextNumberSet(1);
                ToUnlockTextNumberSet(2);
                ToUnlockTextNumberSet(3);
                ToUnlockTextNumberSet(4);
                ToUnlockTextNumberSet(5);
                ToUnlockTextNumberSet(6);
                break;
            case 2:
                ToUnlockTextNumberSet(7);
                ToUnlockTextNumberSet(8);
                break;
            case 3:
                ToUnlockTextNumberSet(9);
                break;
            default:
                break;
        }
    }

}
