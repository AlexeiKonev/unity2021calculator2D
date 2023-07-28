using UnityEngine;
using UnityEngine.UI;

public class TransferNameButton : MonoBehaviour
{
    //имя кнопки служит оператором либо числом
    public string name;
    //ссылка на свою кнопку чтобы подписывать событие нажатия
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
