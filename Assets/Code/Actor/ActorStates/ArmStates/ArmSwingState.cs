﻿using UnityEngine;
using System.Collections;

public class ArmSwingState : ArmState
{
  public override void Initialize()
  {
    throw new System.NotImplementedException();
  }

  public override void OnPress()
  {
    isPressed = true;
  }

  public override void OnRelease()
  {
    isPressed = false;
  }

  public override void PopState()
  {

  }

  public override void PushState()
  {

  }

  public override void Reset()
  {

  }

  public override void Update()
  {

  }
}
