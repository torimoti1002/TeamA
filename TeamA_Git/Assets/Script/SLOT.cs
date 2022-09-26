using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SLOT : MonoBehaviour
{
    public Text rightTex;
    public Text centerTex;
    public Text leftTex;
    private int rightNumber;
    private int centerNumber;
    private int leftNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightNumber = Random.Range(1,7);
        centerNumber = Random.Range(1, 7);
        leftNumber = Random.Range(1, 7);
        rightTex.text = rightNumber.ToString();
    }
}
