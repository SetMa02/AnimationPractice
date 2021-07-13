using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardViewer : MonoBehaviour
{
    [SerializeField] private CardSO _card;
    [SerializeField] private Image _image;
    [SerializeField] private Text _name;

    private void Start()
    {
        _image.sprite = _card.Icon;
        _name.text = _card.Name;
    }
}
