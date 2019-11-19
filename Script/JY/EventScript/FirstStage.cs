using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStage : MonoBehaviour
{

    public KeyWord obj;
    public GameObject Computer;
    public StageManager SMM;
    public ControlDialogue CDManager;

    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(obj.getInfo(0, 4))
        { 
            if(CDManager.isActive)
            {
                if(!CDManager.keywordrunning)
                {
                    CDManager.ExitKeywordDialouge();
                    obj.CloseKeyWord();
                    SMM.FirstAccess();
                    SMM.SetStage();
                    Destroy(gameObject.GetComponent<FirstStage>());
                }
            }
        }
        return;
    }
}
