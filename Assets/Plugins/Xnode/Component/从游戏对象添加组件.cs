﻿using Sirenix.OdinInspector;
using UnityEngine;
using System.Collections.Generic;
using XNode;
namespace 基础事件.对象
{
	public class 从游戏对象添加组件 : Node
	{
		[Input] public GameObject 游戏对象;

		[HideIf("返回数组")] public int 第n个组件;
		private int ArrayIndex;
		public bool 返回数组;
		public enum ValueType
		{
			旧版剧情系统 = 0,
			新版剧情系统 = 1,
			关卡流程控制器 = 2,
			符卡系统 = 3,
			动画播放系统 = 4,
			声音播放系统 = 5,
			激光 = 6,
			发射器 = 7,
			敌人 = 8,
			子弹曲线事件 = 11,
			发射器曲线事件 = 12,
			角色 = 13,
			触发器 = 14,
			贝塞尔曲线 = 15,
			自绘图案 = 16,
			
			力场 = 18,
			精灵纹理渲染器 = 19,
			弹幕连接器 = 20
		}
		public enum GetMethod
		{
			指定对象获取 = 0,
			向上获取 = 1,
			向下获取 = 2
		}
		public ValueType 组件类型;
		private ValueType valueType;
		public GetMethod 操作方式;
		private GetMethod getMethod;
		[Output] public Anything 获取结果;
		[HideInInspector]
		public bool Got = false;
	

		// Use this for initialization
		protected override void Init()
		{
			base.Init();

		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			if (Got != 返回数组 || valueType != 组件类型 || getMethod != 操作方式 || ArrayIndex != 第n个组件 || 游戏对象 == null)
			{
				Got = 返回数组;
				valueType = 组件类型;
				getMethod = 操作方式;
				ArrayIndex = 第n个组件;
				Debug.Log("更新组件引用中");
				游戏对象 = GetInputValue("游戏对象", 游戏对象);
				第n个组件 = GetInputValue<int>("第n个组件", 第n个组件);
				if (游戏对象 == null)
					return null;
				switch (组件类型)
				{
					case ValueType.旧版剧情系统:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<WrittenControlNew>(游戏对象.GetComponents<WrittenControlNew>());
								else
									return 游戏对象.GetComponents<WrittenControlNew>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<WrittenControlNew>(游戏对象.GetComponentsInParent<WrittenControlNew>());
								else
									return 游戏对象.GetComponentsInParent<WrittenControlNew>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<WrittenControlNew>(游戏对象.GetComponentsInChildren<WrittenControlNew>());
								else
									return 游戏对象.GetComponentsInChildren<WrittenControlNew>()[第n个组件];
						}
						break;
					case ValueType.关卡流程控制器:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<StageControl>(游戏对象.GetComponents<StageControl>());
								else
									return 游戏对象.GetComponents<StageControl>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<StageControl>(游戏对象.GetComponentsInParent<StageControl>());
								else
									return 游戏对象.GetComponentsInParent<StageControl>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<StageControl>(游戏对象.GetComponentsInChildren<StageControl>());
								else
									return 游戏对象.GetComponentsInChildren<StageControl>()[第n个组件];
						}
						break;
					case ValueType.力场:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Force>(游戏对象.GetComponents<Force>());
								else
									return 游戏对象.GetComponents<Force>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Force>(游戏对象.GetComponentsInParent<Force>());
								else
									return 游戏对象.GetComponentsInParent<Force>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Force>(游戏对象.GetComponentsInChildren<Force>());
								else
									return 游戏对象.GetComponentsInChildren<Force>()[第n个组件];
						}
						break;
					case ValueType.动画播放系统:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Animator>(游戏对象.GetComponents<Animator>());
								else
									return 游戏对象.GetComponents<Animator>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Animator>(游戏对象.GetComponentsInParent<Animator>());
								else
									return 游戏对象.GetComponentsInParent<Animator>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Animator>(游戏对象.GetComponentsInChildren<Animator>());
								else
									return 游戏对象.GetComponentsInChildren<Animator>()[第n个组件];
						}
						break;
					case ValueType.发射器:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Shooting>(游戏对象.GetComponents<Shooting>());
								else
									return 游戏对象.GetComponents<Shooting>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Shooting>(游戏对象.GetComponentsInParent<Shooting>());
								else
									return 游戏对象.GetComponentsInParent<Shooting>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Shooting>(游戏对象.GetComponentsInChildren<Shooting>());
								else
									return 游戏对象.GetComponentsInChildren<Shooting>()[第n个组件];
						}
						break;
					case ValueType.发射器曲线事件:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<BasedEvent_ShootingLocomotion>(游戏对象.GetComponents<BasedEvent_ShootingLocomotion>());
								else
									return 游戏对象.GetComponents<BasedEvent_ShootingLocomotion>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<BasedEvent_ShootingLocomotion>(游戏对象.GetComponentsInParent<BasedEvent_ShootingLocomotion>());
								else
									return 游戏对象.GetComponentsInParent<BasedEvent_ShootingLocomotion>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<BasedEvent_ShootingLocomotion>(游戏对象.GetComponentsInChildren<BasedEvent_ShootingLocomotion>());
								else
									return 游戏对象.GetComponentsInChildren<BasedEvent_ShootingLocomotion>()[第n个组件];
						}
						break;
					case ValueType.声音播放系统:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<AudioSource>(游戏对象.GetComponents<AudioSource>());
								else
									return 游戏对象.GetComponents<AudioSource>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<AudioSource>(游戏对象.GetComponentsInParent<AudioSource>());
								else
									return 游戏对象.GetComponentsInParent<AudioSource>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<AudioSource>(游戏对象.GetComponentsInChildren<AudioSource>());
								else
									return 游戏对象.GetComponentsInChildren<AudioSource>()[第n个组件];
						}
						break;
					case ValueType.子弹曲线事件:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<BasedEvent_BulletLocomotion>(游戏对象.GetComponents<BasedEvent_BulletLocomotion>());
								else
									return 游戏对象.GetComponents<BasedEvent_BulletLocomotion>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<BasedEvent_BulletLocomotion>(游戏对象.GetComponentsInParent<BasedEvent_BulletLocomotion>());
								else
									return 游戏对象.GetComponentsInParent<BasedEvent_BulletLocomotion>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<BasedEvent_BulletLocomotion>(游戏对象.GetComponentsInChildren<BasedEvent_BulletLocomotion>());
								else
									return 游戏对象.GetComponentsInChildren<BasedEvent_BulletLocomotion>()[第n个组件];
						}
						break;
					case ValueType.敌人:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Enemy>(游戏对象.GetComponents<Enemy>());
								else
									return 游戏对象.GetComponents<Enemy>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Enemy>(游戏对象.GetComponentsInParent<Enemy>());
								else
									return 游戏对象.GetComponentsInParent<Enemy>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Enemy>(游戏对象.GetComponentsInChildren<Enemy>());
								else
									return 游戏对象.GetComponentsInChildren<Enemy>()[第n个组件];
						}
						break;
					
					case ValueType.新版剧情系统:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<DialogSystemInit>(游戏对象.GetComponents<DialogSystemInit>());
								else
									return 游戏对象.GetComponents<DialogSystemInit>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<DialogSystemInit>(游戏对象.GetComponentsInParent<DialogSystemInit>());
								else
									return 游戏对象.GetComponentsInParent<DialogSystemInit>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<DialogSystemInit>(游戏对象.GetComponentsInChildren<DialogSystemInit>());
								else
									return 游戏对象.GetComponentsInChildren<DialogSystemInit>()[第n个组件];
						}
						break;
					case ValueType.符卡系统:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<SpellCard>(游戏对象.GetComponents<SpellCard>());
								else
									return 游戏对象.GetComponents<SpellCard>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<SpellCard>(游戏对象.GetComponentsInParent<SpellCard>());
								else
									return 游戏对象.GetComponentsInParent<SpellCard>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<SpellCard>(游戏对象.GetComponentsInChildren<SpellCard>());
								else
									return 游戏对象.GetComponentsInChildren<SpellCard>()[第n个组件];
						}
						break;
					case ValueType.精灵纹理渲染器:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<SpriteRenderer>(游戏对象.GetComponents<SpriteRenderer>());
								else
									return 游戏对象.GetComponents<SpriteRenderer>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<SpriteRenderer>(游戏对象.GetComponentsInParent<SpriteRenderer>());
								else
									return 游戏对象.GetComponentsInParent<SpriteRenderer>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<SpriteRenderer>(游戏对象.GetComponentsInChildren<SpriteRenderer>());
								else
									return 游戏对象.GetComponentsInChildren<SpriteRenderer>()[第n个组件];
						}
						break;
					case ValueType.自绘图案:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<CustomedPattern>(游戏对象.GetComponents<CustomedPattern>());
								else
									return 游戏对象.GetComponents<CustomedPattern>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<CustomedPattern>(游戏对象.GetComponentsInParent<CustomedPattern>());
								else
									return 游戏对象.GetComponentsInParent<CustomedPattern>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<CustomedPattern>(游戏对象.GetComponentsInChildren<CustomedPattern>());
								else
									return 游戏对象.GetComponentsInChildren<CustomedPattern>()[第n个组件];
						}
						break;
					case ValueType.角色:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Character>(游戏对象.GetComponents<Character>());
								else
									return 游戏对象.GetComponents<Character>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Character>(游戏对象.GetComponentsInParent<Character>());
								else
									return 游戏对象.GetComponentsInParent<Character>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Character>(游戏对象.GetComponentsInChildren<Character>());
								else
									return 游戏对象.GetComponentsInChildren<Character>()[第n个组件];
						}
						break;
					case ValueType.触发器:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Trigger>(游戏对象.GetComponents<Trigger>());
								else
									return 游戏对象.GetComponents<Trigger>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Trigger>(游戏对象.GetComponentsInParent<Trigger>());
								else
									return 游戏对象.GetComponentsInParent<Trigger>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Trigger>(游戏对象.GetComponentsInChildren<Trigger>());
								else
									return 游戏对象.GetComponentsInChildren<Trigger>()[第n个组件];
						}
						break;
					case ValueType.贝塞尔曲线:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<BezierDrawer>(游戏对象.GetComponents<BezierDrawer>());
								else
									return 游戏对象.GetComponents<BezierDrawer>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<BezierDrawer>(游戏对象.GetComponentsInParent<BezierDrawer>());
								else
									return 游戏对象.GetComponentsInParent<BezierDrawer>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<BezierDrawer>(游戏对象.GetComponentsInChildren<BezierDrawer>());
								else
									return 游戏对象.GetComponentsInChildren<BezierDrawer>()[第n个组件];
						}
						break;
					case ValueType.弹幕连接器:
						switch (操作方式)
						{
							case GetMethod.指定对象获取:
								if (返回数组)
									return new List<Link>(游戏对象.GetComponents<Link>());
								else
									return 游戏对象.GetComponents<Link>()[第n个组件];
							case GetMethod.向上获取:
								if (返回数组)
									return new List<Link>(游戏对象.GetComponentsInParent<Link>());
								else
									return 游戏对象.GetComponentsInParent<Link>()[第n个组件];
							case GetMethod.向下获取:
								if (返回数组)
									return new List<Link>(游戏对象.GetComponentsInChildren<Link>());
								else
									return 游戏对象.GetComponentsInChildren<Link>()[第n个组件];
						}
						break;
				}
			
			}
			return null;//
		}
	}
}