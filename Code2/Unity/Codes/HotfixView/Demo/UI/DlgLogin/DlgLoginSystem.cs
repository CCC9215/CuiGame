﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ET
{
	public static  class DlgLoginSystem
	{

		public static void RegisterUIEvent(this DlgLogin self)
		{
			self.View.E_LoginButton.AddListenerAsync(() => { return self.OnLoginClickHandler();});
		}

		public static void ShowWindow(this DlgLogin self, Entity contextData = null)
		{
			self.View.E_AccountInputField.text  = PlayerPrefs.GetString("Account", string.Empty);
			self.View.E_PasswordInputField.text = PlayerPrefs.GetString("Password", string.Empty);

		}
		
		public static async ETTask OnLoginClickHandler(this DlgLogin self)
		{
			try
			{
				string account = self.View.E_AccountInputField.text;
				string password = self.View.E_PasswordInputField.text;
				
				
				int errorCode =  await LoginHelper.Login(self.DomainScene(), ConstValue.LoginAddress, account, password);
				if (errorCode != ErrorCode.ERR_Success)
				{
					Log.Error(errorCode.ToString());
					return;
				}


				errorCode = await LoginHelper.GetServerInfos(self.ZoneScene());
				if (errorCode != ErrorCode.ERR_Success)
				{
					Log.Error(errorCode.ToString());
					return;
				}

				self.DomainScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
				self.DomainScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Server);
				
				PlayerPrefs.SetString("Account",account);
				PlayerPrefs.SetString("Password",password);
			}
			catch (Exception e)
			{
				Log.Error(e.ToString());
			}
		}
		
		public static void HideWindow(this DlgLogin self)
		{

		}
		
	}
}
