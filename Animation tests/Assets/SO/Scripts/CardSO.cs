﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Card", menuName = "Card/Create new card", order = 2)]
public class CardSO : ScriptableObject
{
    [SerializeField]private string _name;
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private Sprite _sprite;

    public string Name => _name;
    public int Health => _health;
    public int Damage => _damage;
    public Sprite Icon => _sprite;
}
