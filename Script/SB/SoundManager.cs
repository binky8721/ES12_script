using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioSource SE;
    public AudioSource BGM;
    public int SE_Number = 0;
    public int BGM_Number = 1;
    bool isChanging = false;
    // Use this for initialization
    void Start () {
        BGM_ListPlay();
        BGM.loop = true;
        //if 효과음일때
        //SE = GetComponent<AudioSource>();
        // AudioClip GoatMilk = (AudioClip)Resources.Load("Sound/Stage1/SE/GoatMilk");
        //AudioClip GoatMilk = Resources.Load("Sound/Stage1/SE/GoatMilk")as AudioClip;
        //SE.PlayOneShot(GoatMilk);
    }

    // Update is called once per frame
    void Update () {
       // SE_List();  update로하면 계속재생해서 소리가 버벅이면서 끊김 한번만 실행해야됨
    }


    public void SE_NumberSet(int num)
    {
        SE_Number = num;
    }

    public void SE_ListPlay()
    {
        SE = GetComponent<AudioSource>();
        switch (SE_Number)
        {
            //염소젖 얻었을시
            case 1:
                AudioClip GoatMilk = Resources.Load("Sound/Stage1/SE/GoatMilk") as AudioClip;
                SE.PlayOneShot(GoatMilk);
                break;
            //우측서랍 열었을시
            case 2:
                AudioClip RdresserOpen = Resources.Load("Sound/Stage1/SE/OpenDrawer2") as AudioClip;
                SE.PlayOneShot(RdresserOpen);
                break;
            //거미줄 창문에 붙일때
            case 3:
                AudioClip LdresserOpen = Resources.Load("Sound/Stage1/SE/UseItem2") as AudioClip;
                SE.PlayOneShot(LdresserOpen);
                break;
            //씨앗심었을시 & 씨앗 얻었을시
            case 4:
                AudioClip PlantSeed = Resources.Load("Sound/Stage1/SE/PlantSeed") as AudioClip;
                SE.PlayOneShot(PlantSeed);
                break;
            //물뿌리개사용 and 하마한테서 물채워질시
            case 5:
                AudioClip Wateringcan = Resources.Load("Sound/Stage1/SE/Wateringcan") as AudioClip;
                SE.PlayOneShot(Wateringcan);
                break;
            //우유병 얻었을시
            case 6:
                AudioClip BottleGet = Resources.Load("Sound/Stage1/SE/BottleGet") as AudioClip;
                SE.PlayOneShot(BottleGet);
                break;
            //종이류 아이템 읽었을시
            case 7:
                AudioClip PaperRead = Resources.Load("Sound/Stage1/SE/PaperRead") as AudioClip;
                SE.PlayOneShot(PaperRead);
                break;
            //평범한 오브젝트(아무런 의미없는) 클릭시
            case 8:
                AudioClip ObjectClick = Resources.Load("Sound/Stage1/SE/ObjectClick") as AudioClip;
                SE.PlayOneShot(ObjectClick);
                break;
            //일반적인 아이템 얻는 소리
            case 9:
                AudioClip GetItem = Resources.Load("Sound/Stage1/SE/GetItem") as AudioClip;
                SE.PlayOneShot(GetItem);
                break;
            //커튼 여닫는 소리
            case 10:
                AudioClip OpenCurtain = Resources.Load("Sound/Stage1/SE/OpenCurtain") as AudioClip;
                SE.PlayOneShot(OpenCurtain);
                break;
            //새지저귐 효과음
            case 11:
                AudioClip BirdCage = Resources.Load("Sound/Stage1/SE/BirdCage") as AudioClip;
                SE.PlayOneShot(BirdCage);
                break;
            //아이템 사용시 (샤샥) -like 칼소리
            case 12:
                AudioClip UseItem = Resources.Load("Sound/Stage1/SE/UseItem") as AudioClip;
                SE.PlayOneShot(UseItem);
                break;
            //물뿌리개 얻었을시
            case 13:
                AudioClip GetWateringcan = Resources.Load("Sound/Stage1/SE/GetWateringcan") as AudioClip;
                SE.PlayOneShot(GetWateringcan);
                break;
            //양머리 칼로 자를시
            case 14:
                AudioClip MeatSlap = Resources.Load("Sound/Stage1/SE/MeatSlap") as AudioClip;
                SE.PlayOneShot(MeatSlap);
                break;
            //아이템 놓았을시 (테이블에다가) & 돌을 모닥불에 놓기 & 새장에 모이,먹이놓기 & 이름표 동화책에 놓기
            case 15:
                AudioClip PutItem = Resources.Load("Sound/Stage1/SE/PutItem") as AudioClip;
                SE.PlayOneShot(PutItem);
                break;
            //금시계침 사용 및 얻음
            case 16:
                AudioClip UseGoldNeedle = Resources.Load("Sound/Stage1/SE/UseGoldNeedle") as AudioClip;
                SE.PlayOneShot(UseGoldNeedle);
                break;
            //망치사용
            case 17:
                AudioClip UseHammer = Resources.Load("Sound/Stage1/SE/UseHammer") as AudioClip;
                SE.PlayOneShot(UseHammer);
                break;
            //부엉이소리
            case 18:
                AudioClip owl = Resources.Load("Sound/Stage1/SE/owl") as AudioClip;
                SE.PlayOneShot(owl);
                break;
            //힌트아이템 얻었을시
            case 19:
                AudioClip Keyword = Resources.Load("Sound/UI/Keyword") as AudioClip;
                SE.PlayOneShot(Keyword);
                break;
            //힌트창 열었을시
            case 20:
                AudioClip HintOpen = Resources.Load("Sound/UI/hint/HintOpen") as AudioClip;
                SE.PlayOneShot(HintOpen);
                break;
            //힌트창 넘길시
            case 21:
                AudioClip HintRead = Resources.Load("Sound/UI/hint/HintRead") as AudioClip;
                SE.PlayOneShot(HintRead);
                break;
            //힌트창 나갈시
            case 22:
                AudioClip HintExit = Resources.Load("Sound/UI/hint/HintExit") as AudioClip;
                SE.PlayOneShot(HintExit);
                break;

            // *************************************************************** 3Stage
            // ********************************1Round

            // 꽃이 필때
            case 300:
                AudioClip Flower = Resources.Load("Sound/Stage3/1Round/FinishFlower") as AudioClip;
                SE.PlayOneShot(Flower);
                break;

            // 물고기먹이 획득,사용
            // 씨앗 획득, 사용
            case 301:
                AudioClip FeedSeed = Resources.Load("Sound/Stage3/1Round/FeedSeed") as AudioClip;
                SE.PlayOneShot(FeedSeed);
                break;

            // 달력, 진단서 등 획득사용
            case 302:
                AudioClip Paper = Resources.Load("Sound/Stage3/1Round/Paper") as AudioClip;
                SE.PlayOneShot(Paper);
                break;
            
            // 카메라 획득, 소라 획득
            case 303:
                AudioClip CameraSora = Resources.Load("Sound/Stage3/1Round/177054__woodmoose__lowerguncock") as AudioClip;
                SE.PlayOneShot(CameraSora);
                break;

            // 은반지 획득,꽃반지 사용, 소라 사용
            case 304:
                AudioClip Ring = Resources.Load("Sound/Stage3/1Round/397608__swordofkings128__scissors-cutting-paper-1") as AudioClip;
                SE.PlayOneShot(Ring);
                break;

            // 서랍 클릭시
            case 305:
                AudioClip Drawer = Resources.Load("Sound/Stage3/1Round/서랍열때2") as AudioClip;
                SE.PlayOneShot(Drawer);
                break;

            // 그림 획득 및 사용
            case 306:
                AudioClip Picture = Resources.Load("Sound/Stage3/1Round/335751__j1987__put-item") as AudioClip;
                SE.PlayOneShot(Picture);
                break;

            // 바다 방문 시
            case 307:
                
                break;

            // 꽃반지 획득
            case 308:
                AudioClip FlowerRing = Resources.Load("Sound/Stage3/1Round/266947__ulfhubert__tiny-ping") as AudioClip;
                SE.PlayOneShot(FlowerRing);
                break;

            // 피아노 클릭
            case 309:
                AudioClip Piano = Resources.Load("Sound/Stage3/1Round/68447__pinkyfinger__piano-g") as AudioClip;
                SE.PlayOneShot(Piano);
                break;

            // 전자 달력 클릭
            case 390:
                AudioClip Clock = Resources.Load("Sound/Stage3/1Round/전자시계 열때") as AudioClip;
                SE.PlayOneShot(Clock);
                break;

            // 전자 달력 숫자 바꿀 때
            case 391:
                AudioClip ClockChange = Resources.Load("Sound/Stage3/1Round/전자시계 숫자 바꿀때") as AudioClip;
                SE.PlayOneShot(ClockChange);
                break;

            // 악보 열 때
            case 392:
                AudioClip MusicNote = Resources.Load("Sound/Stage3/1Round/악보 열때") as AudioClip;
                SE.PlayOneShot(MusicNote);
                break;

            // 낚시대 획득, 사용
            case 393:
                AudioClip Fishing = Resources.Load("Sound/Stage3/1Round/악보 열때") as AudioClip;
                SE.PlayOneShot(Fishing);
                break;

            // 사진 힌트 클릭
            case 394:
                AudioClip PictureHint = Resources.Load("Sound/Stage3/1Round/사진힌트 클릭") as AudioClip;
                SE.PlayOneShot(PictureHint);
                break;

            // 정답일때
            case 395:
                AudioClip CheckTrue = Resources.Load("Sound/Stage3/1Round/정답소리") as AudioClip;
                SE.PlayOneShot(CheckTrue);
                break;

            // 사진 힌트 낱장 클릭할 때
            case 396:
                AudioClip HintClick = Resources.Load("Sound/Stage3/1Round/사진 클릭할때") as AudioClip;
                SE.PlayOneShot(HintClick);
                break;

            // 소파 클릭할 때
            case 397:
                AudioClip SofaClick = Resources.Load("Sound/Stage3/1Round/소파") as AudioClip;
                SE.PlayOneShot(SofaClick);
                break;


            // ********************************2Round

            // 진단서 조각 진단서에 넣을 때
            case 310:
                AudioClip Push = Resources.Load("Sound/Stage3/2Round/진단서 내려놓을때") as AudioClip;
                SE.PlayOneShot(Push);
                break;

            // 달력 클릭
            case 311:
                AudioClip CalengerClcik = Resources.Load("Sound/Stage3/2Round/달력") as AudioClip;
                SE.PlayOneShot(CalengerClcik);
                break;

            // 사진 클릭
            case 312:
                AudioClip PictureClick = Resources.Load("Sound/Stage3/2Round/액자클릭소리") as AudioClip;
                SE.PlayOneShot(PictureClick);
                break;

            // 석상 클릭
            case 313:
                AudioClip ArtClick = Resources.Load("Sound/Stage3/2Round/석상 as AudioClip") as AudioClip;
                SE.PlayOneShot(ArtClick);
                break;


            // ********************************3Round

            // 재규어
            case 320:
                AudioClip Jaguar = Resources.Load("Sound/Stage3/3Round/재규어_mixdown") as AudioClip;
                SE.PlayOneShot(Jaguar);
                break;

            // 좌물쇠 잠금 소리
            case 321:
                AudioClip Rock = Resources.Load("Sound/Stage3/3Round/자물쇠 클릭소리") as AudioClip;
                SE.PlayOneShot(Rock);
                break;

            // 오르골 소리
            case 322:
                AudioClip Orgel = Resources.Load("Sound/Stage3/3Round/오르골줄인거") as AudioClip;
                SE.PlayOneShot(Orgel);
                break;

            // 문 여는 소리
            case 323:
                AudioClip Door = Resources.Load("Sound/Stage3/3Round/open-door") as AudioClip;
                SE.PlayOneShot(Door);
                break;

            // 물뿌리개 획득, 씨앗 획득
            case 324:
                AudioClip WaterCan = Resources.Load("Sound/Stage3/3Round/371217__morganpurkis__pickup") as AudioClip;
                SE.PlayOneShot(WaterCan);
                break;

            // 캐리어 여닫기, 캐리어 획득
            case 325:
                AudioClip Carrier = Resources.Load("Sound/Stage3/3Round/캐리어_mixdown") as AudioClip;
                SE.PlayOneShot(Carrier);
                break;

            // 물뿌리개 사용
            case 326:
                AudioClip UseWaterCan = Resources.Load("Sound/Stage3/3Round/물뿌리개 사용") as AudioClip;
                SE.PlayOneShot(UseWaterCan);
                break;

            // 새모이 사용
            case 327:
                AudioClip UseFeed = Resources.Load("Sound/Stage3/3Round/새모이") as AudioClip;
                SE.PlayOneShot(UseFeed);
                break;

            // 열매 클릭 소리
            case 328:
                AudioClip ClickApple = Resources.Load("Sound/Stage3/3Round/열매클릭소리") as AudioClip;
                SE.PlayOneShot(ClickApple);
                break;

            // 오르골 클릭 소리
            case 329:
                AudioClip ClickOrgel = Resources.Load("Sound/Stage3/3Round/오르골 클릭소리") as AudioClip;
                SE.PlayOneShot(ClickOrgel);
                break;

            // 좌물쇠 숫자 소리
            case 330:
                AudioClip ClickRockNumber = Resources.Load("Sound/Stage3/3Round/자물쇠숫자넘기는소") as AudioClip;
                SE.PlayOneShot(ClickRockNumber);
                break;

            // 장미 얻는 소리
            case 331:
                AudioClip GetRose = Resources.Load("Sound/Stage3/3Round/장미 얻는소리") as AudioClip;
                SE.PlayOneShot(GetRose);
                break;

            // 노이즈 1
            case 400:
                AudioClip Noise1 = Resources.Load("Sound/Ending/채널링노이즈_mixdown") as AudioClip;
                SE.PlayOneShot(Noise1);
                break;

            // 노이즈 2
            case 401:
                AudioClip Noise2 = Resources.Load("Sound/Ending/채널링노이즈2_mixdown - 복사본") as AudioClip;
                SE.PlayOneShot(Noise2);
                break;

            // 노이즈 3
            case 402:
                AudioClip Noise3 = Resources.Load("Sound/Ending/채널링노이즈3 - 복사본") as AudioClip;
                SE.PlayOneShot(Noise3);
                break;

            // 노이즈 4
            case 403:
                AudioClip Noise4 = Resources.Load("Sound/Ending/채널링노이즈4") as AudioClip;
                SE.PlayOneShot(Noise4);
                break;

            // 노이즈 5
            case 404:
                AudioClip Noise5 = Resources.Load("Sound/Ending/마지막 채널링_mixdown") as AudioClip;
                SE.PlayOneShot(Noise5);
                break;

            // 로한 발소리
            case 405:
                AudioClip Foot = Resources.Load("Sound/Ending/로한 들어오는 발소리") as AudioClip;
                SE.PlayOneShot(Foot);
                break;

            // 문 열리는 소리
            case 406:
                AudioClip OpenDoor = Resources.Load("Sound/Ending/문열리는소리_mixdown") as AudioClip;
                SE.PlayOneShot(OpenDoor);
                break;

            // 총 장전 소리
            case 407:
                AudioClip Ready = Resources.Load("Sound/Ending/총 들이대는 소리") as AudioClip;
                SE.PlayOneShot(Ready);
                break;

            // 총 발사
            case 408:
                AudioClip Gun = Resources.Load("Sound/Ending/총쏘는소리") as AudioClip;
                SE.PlayOneShot(Gun);
                break;

            // 총 줍는 소리
            case 409:
                AudioClip GunGet = Resources.Load("Sound/Ending/총 줍는소리") as AudioClip;
                SE.PlayOneShot(GunGet);
                break;

            // 로잘린 발소리
            case 410:
                AudioClip FootWalk = Resources.Load("Sound/Ending/로잘린 마지막 발걸음") as AudioClip;
                SE.PlayOneShot(FootWalk);
                break;
        }
    }

    public void BGM_NumberSet(int num)
    {
        BGM_Number = num;
    }

    public void BGM_ListPlay()
    {
        BGM = GetComponent<AudioSource>();
        switch (BGM_Number)
        {
            /*
            //(1-1Defalut브금)
            case 1:
                ChangeBGM_Fun("Stage1/Bgm/Bgm(1-1Defalut)");
                break;
            */
            
            //(1-1Stage브금)
            case 2:
                ChangeBGM_Fun("Stage1/Bgm/Bgm(1-1)");
                break;
            /*
            //(1-2Defalut브금)
            case 3:
                ChangeBGM_Fun("Stage1/Bgm/Bgm(1-2Defalut)");
                break;
            */
            //(1-2Stage브금)
            case 4:
                ChangeBGM_Fun("Stage1/Bgm/Bgm(1-2)");
                break;

                
        //test2(모닥불사진브금)
            case 5:
                ChangeBGM_Fun("Stage1/Bgm/Picture(BonFire)");
                break;
            //test3(바다사진브금)
            case 6:
                ChangeBGM_Fun("Stage1/Bgm/Picture(Sea)");
                break;
            //test4(테이블사진브금)
            case 7:
                ChangeBGM_Fun("Stage1/Bgm/Picture(Table)");
                break;

             /*
             //(1-3Defalut브금)
             case 10:
                ChangeBGM_Fun("Stage1/Bgm/Bgm(1-3Defalut)");
                 break;
             */

             //(1-3Stage브금)
             case 11:
                ChangeBGM_Fun("Stage1/Bgm/Bgm(1-3)");
                 break;

            // 3-1 BGM
            case 301:
                ChangeBGM_Fun("Stage3/1Round/비창소리키움");
                break;

            // 3-2 BGM
            case 302:
                ChangeBGM_Fun("Stage3/2Round/3-2 BGM");
                break;

            // 3-3 BGM
            case 303:
                ChangeBGM_Fun("Stage3/3Round/3-3 BGM");
                break;

            // 3-1 바다
            case 304:
                ChangeBGM_Fun("Stage3/1Round/바다");
                break;

            // Ending 노이즈배경
            case 400:
                ChangeBGM_Fun("Ending/속닥거리는소리");
                break;

            // Ending 배경음 1
            case 401:
                ChangeBGM_Fun("Ending/Echoes_of_Time_v2");
                break;

            // Ending 배경음 2
            case 402:
                ChangeBGM_Fun("Ending/Precipice");
                break;






        }
    }
   
    public void ChangeBGM_Fun(string NextBGM)
    {
        if (isChanging)
            StopAllCoroutines();
        StartCoroutine(ChangeBGM(NextBGM));
    }
   IEnumerator ChangeBGM(string NextBGM)
    {
        isChanging = true;
        while (BGM.volume>0)
        {
            BGM.volume = BGM.volume - 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
        BGM.Stop();

        AudioClip Nextclip = Resources.Load("Sound/" + NextBGM) as AudioClip;

        BGM.clip = Nextclip;
        BGM.Play();

        while (BGM.volume < 1)
        {
            BGM.volume = BGM.volume + 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
    }


    public void StopSE_fun()
    {
        
        StartCoroutine(StopSE());
    }

    IEnumerator StopSE()
    {
        while (SE.volume > 0)
        {
            SE.volume = SE.volume - 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
        SE.Stop();

        SE.clip = null;
        //SE.Play();

        while (SE.volume < 1)
        {
            SE.volume = SE.volume + 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void StopSound()
    {   
        //if(BGM != null)
        //    StartCoroutine(StopSoundEffect());
        BGM.Stop();
    }
}
