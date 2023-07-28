using UnityEngine;
using UnityEngine.UI;

public class TransferNameButton : MonoBehaviour
{
    //��� ������ ������ ���������� ���� ������
    public string name;
    //������ �� ���� ������ ����� ����������� ������� �������
    public Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(GiveName);

        name = transform.name;

    }

    
    
    public void GiveName()
    {
        Main.instance.screenText += name;
        Main.instance.UpdateScreen();

    }
}
