﻿using UnityEngine;
public class norotate : MonoBehaviour
{
	 Quaternion rotation;
	void Awake()
	{
		rotation = transform.rotation;
	}
	void LateUpdate()
	{
		transform.rotation = rotation;
	}
}