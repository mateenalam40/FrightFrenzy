﻿// Decompiled with JetBrains decompiler
// Type: LevelReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CAF5CC1D-7384-442D-BD63-2B15CA6E7486
// Assembly location: C:\Program Files (x86)\xRC Simulator\xRC Simulator_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
  public void OnPointerClick(PointerEventData data) => SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);

  private void Update()
  {
  }
}
