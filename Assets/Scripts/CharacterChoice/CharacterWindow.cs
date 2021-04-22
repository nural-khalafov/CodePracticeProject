using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterWindow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform m_RectTransform;
    private Vector3 m_ScaleChange;

    private void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        m_RectTransform.localScale = new Vector3(1 * 1.2f, 1* 1.2f, 1);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_RectTransform.localScale = new Vector3(1, 1, 1);
    }
}
