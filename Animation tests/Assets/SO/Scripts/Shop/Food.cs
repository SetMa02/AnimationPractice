using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new food", menuName = "Shop/Food", order = 51)]
public class Food : Shop
{
    [SerializeField] private int _calorie;


    public override void ShowInfo()
    {
        Debug.Log($"Сьедобный товар - {Label} по виду он - {Description} стоит он -{Price} питательный на -{_calorie}");
    }
}
