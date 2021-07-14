using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu( fileName ="new sword", menuName ="Shop/Sword", order =51)]
public class Sword : Shop
{
    [SerializeField] private int _damage;
    public override void ShowInfo()
    {
        Debug.Log($"Меч - {Label} по виду это - {Description} стоит он -{Price} бьет на -{_damage}");
    }
}
