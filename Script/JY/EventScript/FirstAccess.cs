using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAccess : MonoBehaviour {

    public bool con1 = false;
    public bool con2 = false;
    public bool con3 = false;
    public KeyWord obj;
    public KeyWordTrigger TargetObj;

    public StageManager SMM;
    // Use this for initialization
    private void Awake()
    {
        TargetObj = GetComponent<KeyWordTrigger>();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!con1)
            con1 = obj.getInfo(0, 1);
        if (!con2)
            con2 = obj.getInfo(0, 2);
        if (!con3)
            con3 = obj.getInfo(0, 3);
        if (con1 && con2 && con3)
        {
            TargetObj.TriggerKeyword_0Stage();
            Destroy(gameObject.GetComponent<FirstAccess>());
        }
        return;
	}
}
