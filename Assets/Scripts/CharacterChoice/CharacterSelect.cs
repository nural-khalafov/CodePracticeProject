using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    private Text playerName;

    private void Start()
    {
        playerName = GameObject.Find("Text").GetComponent<Text>();
        gameObject.GetComponent<Button>().onClick.AddListener(SelectedCharacter);
    }

    public void SelectedCharacter()
    {
        Debug.Log($"Вы выбрали персонажа {playerName.text}");
    }

}
