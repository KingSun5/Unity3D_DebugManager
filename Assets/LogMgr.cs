
using UnityEngine;

/// <summary>
/// time:2019/4/14
/// author:Sun
/// des:DebugMgr
/// </summary>
public class LogMgr
{
	/// <summary>
	/// 是否关闭Debug
	/// </summary>
	public static bool IsCloseDebug = true;

	/// <summary>
	/// Debug.Log
	/// </summary>
	/// <param name="message"></param>
	public static void Log(object message)
	{
		if (IsCloseDebug) Debug.Log(message);
	}
	
	
	/// <summary>
	/// Debug.LogWarning
	/// </summary>
	/// <param name="message"></param>
	public static void Warning(object message)
	{
		if (IsCloseDebug) Debug.LogWarning(message);
	}
	
	/// <summary>
	/// Debug.LogError
	/// </summary>
	/// <param name="message"></param>
	public static void Error(object message)
	{
		if (IsCloseDebug) Debug.LogError(message);
	}
	

}
