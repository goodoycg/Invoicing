using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Invoicing.Common
{
	/// <summary>
	/// 打印类
	/// </summary>
	public class PrintDraw
	{
		public PrintDraw()
		{
			
		}
		/// <summary>
		/// 显示文本
		/// </summary>
		/// <param name="grf"></param>
		/// <param name="drawString"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="drawFont"></param>
		/// <param name="drawColor"></param>
		/// <param name="StringFlag"></param>
		public static void DrawString(Graphics grf,string drawString,float x,float y,
			Font drawFont,Color drawColor,StringFormatFlags StringFlag)
		{
			SolidBrush drawBrush = new SolidBrush(drawColor);
			StringFormat drawFormat = new StringFormat();
			drawFormat.FormatFlags = StringFlag;
			grf.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
		}
		/// <summary>
		/// 显示文本
		/// </summary>
		/// <param name="grf"></param>
		/// <param name="drawString"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="drawFont"></param>
		/// <param name="drawColor"></param>
		public static void DrawString(Graphics grf,string drawString,float x,float y,
			Font drawFont,Color drawColor)
		{
			SolidBrush drawBrush = new SolidBrush(drawColor);
			StringFormat drawFormat = new StringFormat();
			drawFormat.FormatFlags = StringFormatFlags.LineLimit;
			grf.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
		}
		/// <summary>
		/// 显示文本,默认黑色
		/// </summary>
		/// <param name="grf"></param>
		/// <param name="drawString"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="drawFont"></param>
		/// <param name="StringFlag"></param>
		public static void DrawString(Graphics grf,string drawString,float x,float y,
			Font drawFont,StringFormatFlags StringFlag)
		{
			SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
			StringFormat drawFormat = new StringFormat();
			drawFormat.FormatFlags = StringFlag;
			grf.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
		}
		/// <summary>
		/// 显示文本,默认黑色，默认LineLimit
		/// </summary>
		/// <param name="grf"></param>
		/// <param name="drawString"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="drawFont"></param>
		public static void DrawString(Graphics grf,string drawString,float x,float y,Font drawFont)
		{
			SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
			StringFormat drawFormat = new StringFormat();
			drawFormat.FormatFlags = StringFormatFlags.LineLimit;
			grf.DrawString(drawString, drawFont, drawBrush, x, y,drawFormat);
		}
		/// <summary>
		/// 固定大小显示文本
		/// </summary>
		/// <param name="grf"></param>
		/// <param name="drawString"></param>
		/// <param name="drawFont"></param>
		/// <param name="drawColor"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public static void DrawString(Graphics grf,string drawString,float x,float y,float width,float height,
			StringAlignment strAlign,Font drawFont,System.Drawing.Color color)
		{
			
			// Create font and brush.
			SolidBrush drawBrush = new SolidBrush(color);

			RectangleF drawRect = new RectangleF( x, y, width, height);
			// Draw rectangle to screen.
			Pen blackPen = new Pen(Color.Black);
			//grf.DrawRectangle(blackPen, x, y, width, height);
			// Set format of string.
			StringFormat drawFormat = new StringFormat();
			drawFormat.Alignment = strAlign;
            drawFormat.LineAlignment = StringAlignment.Center;
			// Draw string to screen.
			grf.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
		}

		/// <summary>
		/// 固定大小显示文本，默认黑色
		/// </summary>
		/// <param name="grf"></param>
		/// <param name="drawString"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="strAlign"></param>
		/// <param name="drawFont"></param>
		public static void DrawString(Graphics grf,string drawString,float x,float y,float width,float height,
			StringAlignment strAlign,Font drawFont)
		{
			// Create font and brush.
			SolidBrush drawBrush = new SolidBrush(Color.Black);

			RectangleF drawRect = new RectangleF( x, y, width, height);
			// Draw rectangle to screen.
			Pen blackPen = new Pen(Color.Black);
			//grf.DrawRectangle(blackPen, x, y, width, height);
			// Set format of string.
			StringFormat drawFormat = new StringFormat();
			drawFormat.Alignment = strAlign;
            drawFormat.LineAlignment = StringAlignment.Center;
			// Draw string to screen.
			grf.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
		}
		

	}
}

