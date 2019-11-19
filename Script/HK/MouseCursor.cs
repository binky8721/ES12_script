using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour {

    // 마우스 포인터로 사용할 텍스쳐 입력 받기

    public Texture2D BasicCursorTexture;
    public Texture2D EyesCursorTexture;
    public Texture2D ExitCursorTexture;
    public Texture2D LeftCursorTexture;
    public Texture2D RightCursorTexture;


    private Vector2 hotSpot = Vector2.zero;

    public bool bCursorChage = false;

    void Start()
    {
        Cursor.SetCursor(BasicCursorTexture, hotSpot, CursorMode.Auto);
        hotSpot.x = 0.0f;
        hotSpot.y = 0.0f;
    }

    void Update()
    {
        /*
         * 오브젝트와 충돌시 eyes커서로 변경
         * 충돌이 아닐 때는 basic커서로 변경  
         */
        /*if (bCursorChage)
            Cursor.SetCursor(EyesCursorTexture, hotSpot, CursorMode.Auto);

        else
            Cursor.SetCursor(BasicCursorTexture, hotSpot, CursorMode.Auto);*/
    }


    public void PointerChange(bool active)
    {
        bCursorChage = active;
    }

    public void PointerChangetoExit()
    {
        Cursor.SetCursor(ExitCursorTexture, hotSpot, CursorMode.Auto);
    }

    public void PointerChangtoEyes()
    {

        Cursor.SetCursor(EyesCursorTexture, hotSpot, CursorMode.Auto);
    }

    public void PointerChangetoNormal()
    { 

        Cursor.SetCursor(BasicCursorTexture, hotSpot, CursorMode.Auto);
    }

    public void PointerChangetoLeft()
    {

        Cursor.SetCursor(LeftCursorTexture, hotSpot, CursorMode.Auto);
    }

    public void PointerChangetoRight()
    {

        Cursor.SetCursor(RightCursorTexture, hotSpot, CursorMode.Auto);
    }
}
