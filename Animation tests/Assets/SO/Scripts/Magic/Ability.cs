using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Abillities/new ability")]

public class Ability : ScriptableObject
{
    [SerializeField] private AbillityPlaceLigic placeLigic;

    public void ApplyAction(List<Unit> target)
    {

    }

    public List<Unit> SelectedTargets(Vector2 screenPoint)
    {
        return placeLigic.TryGetTargets(screenPoint);
    }
}
