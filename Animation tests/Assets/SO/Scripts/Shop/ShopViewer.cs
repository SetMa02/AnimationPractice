using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopViewer : MonoBehaviour
{
    [SerializeField] private Shop[] goods;
    private void Start()
    {
        foreach (var i in goods)
        {
            i.ShowInfo();
        }
    }
}
