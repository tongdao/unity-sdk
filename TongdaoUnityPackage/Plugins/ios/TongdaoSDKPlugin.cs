using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using System.Threading;

public class TongdaoSDKPlugin : MonoBehaviour {

	const string version = "3.2.4";

	static TongdaoSDKPlugin _tongrdPlugin;

	#if UNITY_IPHONE
	/* Interface to native implementation */

	[DllImport ("__Internal")]
	private static extern void tongrdInit(string appKey, string userId);
	[DllImport ("__Internal")]
	private static extern void tongrdLoginWith(string userId);
	[DllImport ("__Internal")]
	private static extern void tongrdIdentifyPushToken(string pushToken);
	[DllImport ("__Internal")]
	private static extern void tongrdTrackWithEventName(string eventName);
	[DllImport ("__Internal")]
	private static extern void tongrdDownloadInAppMessage(object view);
	[DllImport ("__Internal")]
	private static extern void tongrdTrackOpenPage(string pageName);
	[DllImport ("__Internal")]
	private static extern void tongrdTrackClosePage(string pageName);

	#endif

	/* Public interface for use inside C# / JS code */

	public static void Init(string appKey, string userId)
	{
		// Call plugin only when running on real device
		if (Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsEditor)
		if (_tongrdPlugin == null)
		{
			_tongrdPlugin = GameObject.FindObjectOfType<TongdaoSDKPlugin>();
			if (_tongrdPlugin == null)
			{
				_tongrdPlugin = new GameObject ("TongdaoSDKPlugin").AddComponent<TongdaoSDKPlugin> ();
			}
		}

		#if UNITY_IPHONE
		tongrdInit(appKey, userId);
		#endif

		#if UNITY_ANDROID

		#endif
	}
	public static void Login(string userId){
		#if UNITY_IPHONE
		tongrdLoginWith(userId);
		#endif

		#if UNITY_ANDROID

		#endif
	}
	public static void sendPushToken(string pushToken){
		#if UNITY_IPHONE
		tongrdIdentifyPushToken(pushToken);
		#endif

		#if UNITY_ANDROID

		#endif
	}
	public static void TrackWithEventName(string eventName){
		#if UNITY_IPHONE
		tongrdTrackWithEventName(eventName);
		#endif

		#if UNITY_ANDROID

		#endif
	}
	public static void TrackOpenPage(string pageName){
		#if UNITY_IPHONE
		tongrdTrackOpenPage(pageName);
		#endif

		#if UNITY_ANDROID

		#endif
	}
	public static void TrackClosePage(string pageName){
		#if UNITY_IPHONE
		tongrdTrackClosePage(pageName);
		#endif

		#if UNITY_ANDROID

		#endif
	}
	public static void downLoadInappMessage(object pageName){
		#if UNITY_IPHONE
		tongrdDownloadInAppMessage(pageName);
		#endif

		#if UNITY_ANDROID

		#endif
	}

}
