using System;
using UnityEngine;

public class DebugUtil
{
	static private Vector3 offsetStart = new Vector3(0f,2f,0f);
	static private Vector3 offsetEnd = new Vector3(0f,0f,0f);
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null. Uses default offset
	/// </summary>
	/// <param name='start'>
	/// Object to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Object to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	public static void DrawLine(Transform start, Transform dest, Color color)
	{
		if(start != null && dest != null)
		{
			DrawLine(start, dest, color, true);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Object to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Object to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offset'>
	/// If true a default offset will be used. Default is: start = (0f, 2f, 0f) and end (0f,0f,0f)
	/// </param>
	public static void DrawLine(Transform start, Transform dest, Color color, bool offset)
	{
		if(start != null && dest != null)
		{
			DrawLine(start.position, dest.position, color, offset);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Object to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Point to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offset'>
	/// If true a default offset will be used. Default is: start = (0f, 2f, 0f) and end (0f,0f,0f)
	/// </param>
	public static void DrawLine(Transform start, Vector3 dest, Color color, bool offset)
	{
		if(start != null)
		{
			DrawLine(start.position, dest, color, offset);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Point to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Point to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offset'>
	/// If true a default offset will be used. Default is: start = (0f, 2f, 0f) and end (0f,0f,0f)
	/// </param>
	public static void DrawLine(Vector3 start, Transform dest, Color color, bool offset)
	{
		if(dest != null)
		{
			DrawLine(start, dest.position, color, offset?offsetStart:Vector3.zero, offset?offsetEnd:Vector3.zero);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Point to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Point to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offset'>
	/// If true a default offset will be used. Default is: start = (0f, 2f, 0f) and end (0f,0f,0f)
	/// </param>
	public static void DrawLine(Vector3 start, Vector3 dest, Color color, bool offset)
	{
		DrawLine(start, dest, color, offset?offsetStart:Vector3.zero, offset?offsetEnd:Vector3.zero);
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Object to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Object to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offsetStart'>
	/// Offset for the start point.
	/// </param>
	/// <param name='offsetEnd'>
	/// Offset for the end point.
	/// </param>
	public static void DrawLine(Transform start, Transform dest, Color color, Vector3 offsetStart, Vector3 offsetEnd)
	{
		if(start != null && dest != null)
		{
			DrawLine(start.position, dest.position, color, offsetStart, offsetEnd);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Point to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Object to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offsetStart'>
	/// Offset for the start point.
	/// </param>
	/// <param name='offsetEnd'>
	/// Offset for the end point.
	/// </param>
	public static void DrawLine(Vector3 start, Transform dest, Color color, Vector3 offsetStart, Vector3 offsetEnd)
	{
		if(dest != null)
		{
			DrawLine(start, dest.position, color, offsetStart, offsetEnd);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Object to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Point to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offsetStart'>
	/// Offset for the start point.
	/// </param>
	/// <param name='offsetEnd'>
	/// Offset for the end point.
	/// </param>
	public static void DrawLine(Transform start, Vector3 dest, Color color, Vector3 offsetStart, Vector3 offsetEnd)
	{
		if(start != null)
		{
			DrawLine(start.position, dest, color, offsetStart, offsetEnd);
		}
	}
	
	/// <summary>
	/// Draws a line via Debug of UnityEngine. Adds comfort by letting you define an offset for startpoint and endpoint. Also checks for null
	/// </summary>
	/// <param name='start'>
	/// Point to start the line at.
	/// </param>
	/// <param name='dest'>
	/// Point to end the line at.
	/// </param>
	/// <param name='color'>
	/// Color of the line.
	/// </param>
	/// <param name='offsetStart'>
	/// Offset for the start point.
	/// </param>
	/// <param name='offsetEnd'>
	/// Offset for the end point.
	/// </param>
	public static void DrawLine(Vector3 start, Vector3 dest, Color color, Vector3 offsetStart, Vector3 offsetEnd)
	{
		Debug.DrawLine(start + offsetStart, dest + offsetEnd, color);	
	}

	public static void DrawRay(Vector3 start, Vector3 dir, Color color)
	{
		DrawRay(start,dir,color, Vector3.zero);
	}


	public static void DrawRay(Transform start, Vector3 dir, Color color)
	{
		if(start != null)
		{
			DrawRay(start,dir,color, Vector3.zero);
		}
	}
	
	/// <summary>
	/// Draws a ray via Debug of UnityEngine. Adds comfort by letting you define an offset for the starting point and checking for null.
	/// </summary>
	/// <param name='start'>
	/// Object where to start at.
	/// </param>
	/// <param name='dir'>
	/// Direction and length of the ray.
	/// </param>
	/// <param name='color'>
	/// Color of the ray.
	/// </param>
	/// <param name='offsetStart'>
	/// Offset from the start Object to start the ray at.
	/// </param>
	public static void DrawRay(Transform start, Vector3 dir, Color color, Vector3 offsetStart)
	{
		if(start != null)
		{
			DrawRay(start.position, dir, color, offsetStart);
		}	
	}
	
	/// <summary>
	/// Draws a ray via Debug of UnityEngine. Adds comfort by letting you define an offset for the starting point and checking for null.
	/// </summary>
	/// <param name='start'>
	/// Global point to start at.
	/// </param>
	/// <param name='dir'>
	/// Direction and length of the ray.
	/// </param>
	/// <param name='color'>
	/// Color of the ray.
	/// </param>
	/// <param name='offsetStart'>
	/// Offset from the start Object to start the ray at.
	/// </param>
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, Vector3 offsetStart)
	{
		Debug.DrawRay(start + offsetStart, dir, color);	
	}
	
	/// <summary>
	/// Assertion exception.
	/// Don't catch this Exception, because if this exception is thrown, the implementation is wrong!
	/// </summary>
	public class AssertionException:Exception
	{
		public AssertionException(String message):base(message)
		{
		}
	}
	
	/// <summary>
	/// Assert the specified condition and trow a AssertionException with the specified message.
	/// </summary>
	/// <param name='condition'>
	/// Condition that have to be true.
	/// </param>
	/// <param name='message'>
	/// Message of the trown exception.
	/// </param>
	/// <exception cref='AssertionException'>
	/// Is thrown when the assertion is not true.
	/// </exception>
	[System.Diagnostics.Conditional("DEBUG_ASSERTIONS")]
	public static void Assert(bool condition, String message)
	{
		if(!condition) throw new AssertionException(message);
	}
}