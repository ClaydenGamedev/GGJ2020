﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CollarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMP_Text>().text = MeowManager.Instance.CatName;
    }

   
}
