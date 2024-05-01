using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private TMP_Text TextToChange;

    private Color32 _originalColor = new Color32(255, 255, 255, 255);
    private Color32 _targetColor = new Color32(100, 155, 33, 255);
    private Vector3 _startScale;
    private float _scaleToSize = 1.1f;
    private void Start()
    {
        TextToChange = GetComponent<TextMeshProUGUI>();
        _originalColor = TextToChange.color;
        _startScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TextToChange.color = _targetColor;
        transform.localScale = _startScale * _scaleToSize;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TextToChange.color = _originalColor;
        transform.localScale = _startScale;
    }



}
