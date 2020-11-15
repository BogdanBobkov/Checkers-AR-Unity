﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class UiFinishMenu : MonoBehaviour
    {
        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);
    }
}
