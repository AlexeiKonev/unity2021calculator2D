using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static Main instance;
    private float sum = 0;
   //������ ������� ����� �������� �� ��������� � ����� ��� ����������
    public string screenText;
    public TextMeshProUGUI screen;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }


    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Space)) { UpdateScreen(); }
    }
    public void UpdateScreen()
    {
        screen.text = screenText;
    }
    //����� ��� ������ ����� "="
    public void Result()
    {
      foreach(var item in screenText)
        {
            var x = item;

            item.Equals('+');
            
        }    
    }
}
