using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private Canvas _pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        //CanvasがONならOFFにする
        if(_pauseCanvas.gameObject.activeSelf) _pauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //キー入力を確認したらCanvasのONOFFを切り替える
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CanvasOnOff(_pauseCanvas);
        } 
    }
    public void ButtonPause()
    {
        SceneManager.LoadScene("Title");
    }
    /// <summary>
    /// CanvasのONOFFを切り替える関数
    /// </summary>
    /// <param name="canvas">切り替えるCanvas</param>
    private void CanvasOnOff(Canvas canvas)
    {
        if (!canvas.gameObject.activeSelf) canvas.gameObject.SetActive(true);
        else canvas.gameObject.SetActive(true);
    }
}
