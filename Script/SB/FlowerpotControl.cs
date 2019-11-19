﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerpotControl : MonoBehaviour {
    public GameObject FlowerLayer;

    // PSO : PlantStateObject
    public GameObject PSO_Carrot;
    public GameObject PSO_Foxtail;
    public GameObject PSO_Potato;
    public GameObject PSO_Bean;


    public GameObject CarrotSeed;
    public GameObject FoxtailSeed;
    public GameObject PotatoSeed;
    public GameObject BeanSeed;

    public GameObject EmptyArea;
    //화분에 심어져있는 상태
    public bool IsPlantCarrot = false;
    public bool IsPlantFoxtail = false;
    public bool IsPlantPotato = false;
    public bool IsPlantBean = false;

    public bool IsPlanted = false;

    //씨앗 사용 여부
    public bool CarrotSeedUse = false;
    public bool FoxtailSeedUse = false;
    public bool PotatoSeedUse = false;
    public bool BeanSeedUse = false;

    //배경 화분 이미지
    public Image FlowerEnter2;

    //1-3 배경 화분 이미지
    public Image FlowerEnter3;

    public GameObject RosePlant; // 장미가 심어졌을시 바로 활성화
    public GameObject TreePlant; // 자란나무에 금침을 놓아서 다자란상태
    public GameObject SmallTree; // 조금자란 나무
    //1-3 화분에 심어져있는 상태
    public bool IsPlantTree = false;
    
    public bool IsPlantRose = false;
    //public bool IsPlantSmallTree = false;

    public void CheckBackPot()
    {
        if (RosePlant.activeSelf)
        {
            IsPlantRose = true;
            FlowerEnter3.sprite = Resources.Load<Sprite>("Stage1-3/BackPotState/RoseBack");
        }
        else if(SmallTree.activeSelf)
        {
            FlowerEnter3.sprite = Resources.Load<Sprite>("Stage1-3/BackPotState/SmallTreeBack");
        }
        else if (TreePlant.activeSelf)
        {
            IsPlantTree = true;
            FlowerEnter3.sprite = Resources.Load<Sprite>("Stage1-3/BackPotState/TreeBack");
        }
        else
        {
            FlowerEnter3.sprite = Resources.Load<Sprite>("Stage1-3/BackPotState/FlowerPotBack");
        }

    }

    void Start()
    {
        
    }


    void Update()
    {
        EmptyAreaSet();
        CheckBackPot();
    }

    //작물이 심어져있는 상태일때 씨앗에 투명이미지를 씌워서 씨앗을 심지못하게 방지
    void EmptyAreaSet()
    {
        if (IsPlanted)
        {
            EmptyArea.transform.Find("EmptyArea1").gameObject.SetActive(true);
            EmptyArea.transform.Find("EmptyArea2").gameObject.SetActive(true);
            //Area1(토끼+개) Area2(새,돼지)
            //씨앗을 둘다 사용했을경우 EmptyArea끄기
            if (!CarrotSeed.activeSelf && !FoxtailSeed.activeSelf)
                EmptyArea.transform.Find("EmptyArea1").gameObject.SetActive(false);
            if (!PotatoSeed.activeSelf && !BeanSeed.activeSelf)
                EmptyArea.transform.Find("EmptyArea2").gameObject.SetActive(false);
        }
        //else if(!IsPlanted)
        else
        {
            EmptyArea.transform.Find("EmptyArea1").gameObject.SetActive(false);
            EmptyArea.transform.Find("EmptyArea2").gameObject.SetActive(false);
        }
    }

    public void PlantCheck()
    {
        IsPlanted = true;
    }

    public void PlantCarrot()
    {
        IsPlantCarrot = true;
    }
    public void PlantFoxtail()
    {
        IsPlantFoxtail = true;
    }
    public void PlantPotato()
    {
        IsPlantPotato = true;
    }
    public void PlantBean()
    {
        IsPlantBean = true;
    }

    public void GetCarrot()
    {
        IsPlantCarrot = false;
        IsPlanted = false;
        FlowerEnter2.sprite = Resources.Load<Sprite>("Stage1-2/Flowerpot/Pot01");
    }
    public void GetPotato()
    {
        IsPlantPotato = false;
        IsPlanted = false;
        FlowerEnter2.sprite = Resources.Load<Sprite>("Stage1-2/Flowerpot/Pot01");
    }
    public void CutFoxtail()
    {
        IsPlantFoxtail = false;
        IsPlanted = false;
    }
    public void CutBean()
    {
        IsPlantBean = false;
        IsPlanted = false;
    }

    public void UsingSeedCheck()
    {
        if(CarrotSeedUse)
        {
            CarrotSeed.SetActive(false);
        }
        if (FoxtailSeedUse)
        {
            FoxtailSeed.SetActive(false);
        }
        if (PotatoSeedUse)
        {
            PotatoSeed.SetActive(false);
        }
        if (BeanSeedUse)
        {
            BeanSeed.SetActive(false);
        }
    }

    public void CutWrongPlant()
    {
        IsPlanted = false;
    }

    //추가할 사항
    //1.꽝작물(강아지풀,콩)을 심어버린경우 다시심으려면 커터칼로 잘라야한다.

    public void ShowPlantedFlowerpot()
    {
        FlowerLayer.SetActive(true);
        /*
        if (IsPlanted)
        {
            if (IsPlantCarrot)
            {
                //심어진 작물(당근)을 제외한 다른 작물은 해제상태로
                PSO_Carrot.SetActive(true);
                PSO_Foxtail.SetActive(false);
                PSO_Potato.SetActive(false);
                PSO_Bean.SetActive(false);
                return;
            }
            else if (IsPlantFoxtail)
            {
                //심어진 작물(강아지풀)을 제외한 다른 작물은 해제상태로
                PSO_Carrot.SetActive(false);
                PSO_Foxtail.SetActive(true);
                PSO_Potato.SetActive(false);
                PSO_Bean.SetActive(false);
                return;
            }
            else if (IsPlantPotato)
            {
                //심어진 작물(감자)을 제외한 다른 작물은 해제상태로
                PSO_Carrot.SetActive(false);
                PSO_Foxtail.SetActive(false);
                PSO_Potato.SetActive(true);
                PSO_Bean.SetActive(false);
                return;
            }
            else if (IsPlantBean)
            {
                //심어진 작물(콩)을 제외한 다른 작물은 해제상태로
                PSO_Carrot.SetActive(false);
                PSO_Foxtail.SetActive(false);
                PSO_Potato.SetActive(false);
                PSO_Bean.SetActive(true);
                return;
            }
            PSO_Carrot.SetActive(false);
            PSO_Foxtail.SetActive(false);
            PSO_Potato.SetActive(false);
            PSO_Bean.SetActive(false);
        }
        */
    }

    public void ExitFlowerpot()
    {
        FlowerLayer.SetActive(false);
    }


    //1-3
    public void GetRose()
    {
        IsPlantRose = false;
    }
    public void GetTree()
    {
        IsPlantTree = false;
    }

}
