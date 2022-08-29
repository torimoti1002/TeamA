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
        //Canvas��ON�Ȃ�OFF�ɂ���
        if(_pauseCanvas.gameObject.activeSelf) _pauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�L�[���͂��m�F������Canvas��ONOFF��؂�ւ���
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
    /// Canvas��ONOFF��؂�ւ���֐�
    /// </summary>
    /// <param name="canvas">�؂�ւ���Canvas</param>
    private void CanvasOnOff(Canvas canvas)
    {
        if (!canvas.gameObject.activeSelf) canvas.gameObject.SetActive(true);
        else canvas.gameObject.SetActive(true);
    }
}
