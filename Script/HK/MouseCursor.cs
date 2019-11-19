using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour {

    // ���콺 �����ͷ� ����� �ؽ��� �Է� �ޱ�

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
         * ������Ʈ�� �浹�� eyesĿ���� ����
         * �浹�� �ƴ� ���� basicĿ���� ����  
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
