using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using UnityEngine.UI;
public class GameLoader : MonoBehaviour
{

    public ControlDialogue CDManager;
    public TextChange TCManager;

    public KeyWord KWManager;
    JsonData ConversationData;
    int StatusofStage;
    public Image savingImage;
    public Image loadImage;

    public EventManager EM;
    public TextAsset initialdata;
    string savePath;

    public bool isMobilever = false;
    public GameObject MachineManual;

    // Update is called once per frame
    private void Awake()
    {
        if (!isMobilever)
        {
            savePath = Application.streamingAssetsPath + "/ES12/Data";
        }
        else
            savePath = Application.persistentDataPath + "/ES12/Data";
        DirectoryInfo di = new DirectoryInfo(savePath);
        if(!di.Exists)
        {
            di.Create();
            
            ConversationData = JsonMapper.ToJson(JsonMapper.ToObject(initialdata.text));

            File.WriteAllText(savePath + "/DATA.json", ConversationData.ToString());
            File.WriteAllText(savePath + "/stage.txt", "0");
        }
        Debug.Log(savePath);
    }
    void Update()
    {

    }

    public void SaveGame(int stage)
    {
        ConversationData = JsonMapper.ToJson(KWManager.GetKeywordData());
        StatusofStage = stage;

        File.WriteAllText(savePath+"/DATA.json", ConversationData.ToString());
        File.WriteAllText(savePath + "/stage.txt", StatusofStage.ToString());
        StartCoroutine(SavingImage());
    }

    public void SaveKeywordData()
    {
        ConversationData = JsonMapper.ToJson(KWManager.GetKeywordData());
        File.WriteAllText(savePath + "/DATA.json", ConversationData.ToString());
        StartCoroutine(SavingImage());

    }
    public int LoadGame()
    {
        ConversationData = JsonMapper.ToObject(File.ReadAllText(savePath + "/DATA.json"));

        StatusofStage = int.Parse(File.ReadAllText(savePath + "/stage.txt"));

        KWManager.LoadKeyWord(ConversationData);

        TCManager.LoadHint(StatusofStage);
        StartCoroutine(LoadImage());
        if (StatusofStage != 0)
        {
            EM.EventnumberSet(955);
            MachineManual.SetActive(false);
        }
        return StatusofStage;
    }

    IEnumerator SavingImage()
    {
        bool running = true;
        float transition = 0;
        while (running)
        {
            savingImage.color = Color.Lerp(new Color(255, 255, 255, 0), new Color(255, 255, 255, 1), transition);
            transition = transition + 0.1f;
            if (transition >= 1)
                running = false;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2.0f);
        running = true;
        while (running)
        {

            savingImage.color = Color.Lerp(new Color(255, 255, 255, 0), new Color(255, 255, 255, 1), transition);
            transition = transition - 0.1f;
            if (transition <= 0)
                running = false;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator LoadImage()
    {
        bool running = true;
        float transition = 0;
        while (running)
        {
            loadImage.color = Color.Lerp(new Color(255, 255, 255, 0), new Color(255, 255, 255, 1), transition);
            transition = transition + 0.1f;
            if (transition >= 1)
                running = false;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2.0f);
        running = true;
        while (running)
        {
            loadImage.color = Color.Lerp(new Color(255, 255, 255, 0), new Color(255, 255, 255, 1), transition);
            transition = transition - 0.1f;
            if (transition <= 0)
                running = false;
            yield return new WaitForSeconds(0.01f);
        }
    }
}