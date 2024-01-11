using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    struct ColorRef

    {

        public byte red,
        green,
        blue;

        private byte unused;

        public ColorRef(byte r, byte g, byte b)

        {

            red = r;

            green = g;

            blue = b;

            unused = 0;

        }

    }
    static class UnmanagedCode
    {
        [DllImport("GraphicLib.dll")]

        private static extern void MyDrawLine(System.IntPtr hdc, int x1, int y1, int x2, int y2, ColorRef color, int width);

        private static void GetGraphicsInitialization()
        {
            Graphics g = CreateGraphics();

            System.IntPtr hdc = g.GetHdc();
            ColorRef red = new ColorRef(255, 0, 0);

            MyDrawLine(hdc, 0, 0, 150, 200, red, 1);

            g.ReleaseHdc(hdc);

            g.Dispose();
        }

        private static Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
