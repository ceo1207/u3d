// 在OnGUI中创建button，使用GUISkin，实现开始界面
using UnityEngine;
using UnityEditor.SceneManagement;
public class p1 : MonoBehaviour
{
    public GUISkin customSkin;
    private float width;
    private float height;
    private float screenWidth;
    // Start is called before the first frame update
    void Start()
    {
        width = 100;
        height = 50;
        screenWidth = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.skin = customSkin;
        if(GUI.Button(new Rect(screenWidth-width/2, 300, width, height), "Play"))
        {
            //SceneManager.LoadScene("play");
            Application.LoadLevel("play");
        }
    }

}
