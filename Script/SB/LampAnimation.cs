using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampAnimation : MonoBehaviour {

    /*
    public Sprite[] sprites; //스프라이트 받아옴
    private SpriteRenderer myRenderer; //스프라이터를 렌더하기위해 호출
    float time = 0; //시간을 위해 사용
    int count = 0; //몇개를 했는지 알아보기위해..

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime; //지나는 시간을 계속하여 저장
        if (count > 4)
            return; //count가 이미지의 최대 갯수 만큼되면 return;
        else if(time>=1.5f && count ==0) //시간이 1.5초경과(첫번째)
        {
            myRenderer = gameObject.GetComponent<SpriteRenderer>(); //렌더 적용할 객체
            myRenderer.sprite = sprites[count];
            count++; //증가하여 다음 이미지 적용준비
        }
        else if(time>=1.55f && count == 1)
        {
            myRenderer = gameObject.GetComponent<SpriteRenderer>(); //렌더 적용할 객체
            myRenderer.sprite = sprites[count];
            count++;
        }
        else if (time >= 1.60f && count == 2)
        {
            myRenderer = gameObject.GetComponent<SpriteRenderer>(); //렌더 적용할 객체
            myRenderer.sprite = sprites[count];
            count++;
        }
        else if (time >= 1.65f && count == 3)
        {
            myRenderer = gameObject.GetComponent<SpriteRenderer>(); //렌더 적용할 객체
            myRenderer.sprite = sprites[count];
            time = 0; //시간을 다시 0초로
            count++;
        }
    }
    */
    
    public Sprite[] sprites;
    public int spritePerFrame = 14;
    public bool loop = true;
    public bool destroyOnEnd = false;

    private int index = 0;
    private Image image;
    private int frame = 0;

    float time = 0; //시간을 위해 사용
    int count = 0; //몇개를 했는지 알아보기위해..

    void Awake()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!loop && index == sprites.Length)
            return;
        frame++;
        if (frame < spritePerFrame)
            return;
        //image.sprite = sprites[index];

        time += Time.deltaTime; //지나는 시간을 계속하여 저장
        while (index < 4)
        {
            if (time <= 1.5f && index == 0) //시간이 1.5초경과(첫번째)
            {
                Debug.Log("1번째");
                image.sprite = sprites[index];
                index++; //증가하여 다음 이미지 적용준비
            }
            else if (time >= 1.55f && index == 1)
            {
                Debug.Log("1번째");
                image.sprite = sprites[index];
                index++;
            }
            else if (time >= 1.60f && index == 2)
            {
                Debug.Log("1번째");
                image.sprite = sprites[index];
                index++;
            }
            else if (time >= 1.65f && index == 3)
            {
                Debug.Log("1번째");
                image.sprite = sprites[index];
                time = 0; //시간을 다시 0초로
                index++;
            }
        }

        frame = 0;
        //index++;
        if (index >= sprites.Length)
        {
            if (loop)
                index = 0;
            if (destroyOnEnd)
                Destroy(gameObject);
        }

    }
}
