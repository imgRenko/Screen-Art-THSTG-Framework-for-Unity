﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
namespace 基础事件.全局.玩家
{
public class 玩家灵力 : Node {
	[Output] public float 灵力数;
	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port) {
		return Global.Power; // Replace this
	}
}}