using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace xchanmolxBot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
          int dwExtraInfo);

        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010,
            WHEEL = 0x00000800,
            XDOWN = 0x00000080,
            XUP = 0x00000100
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClickButton();
            Thread.Sleep(7000);
            for (int i = 1; i < 30000; i++)
            {
                ClickButton2();
                Thread.Sleep(13000);
                ClickButton3();
                Thread.Sleep(5000);
                ClickButton4();
                Thread.Sleep(13000);
                ClickButton5();
                Thread.Sleep(10000);
                ClickButton2();
                Thread.Sleep(13000);
                ClickButton3();
                Thread.Sleep(5000);
                ClickButton4();
                Thread.Sleep(13000);
            }
        }

        private void ClickButton()
        {
            /*
             *     [x] Snapshot of the whole screen.
             *     [x] Find the login button and check if it exists.
             *     [x] Move the mouse to login button.
             *     [ ] Click the login button.
             */

            // Takes a snapshot of the screen.
            Bitmap bmpScreenshot = Screenshot();

            // Makes the background of the form a screenshot of the screen.
            this.BackgroundImage = bmpScreenshot;

            // Find the login button and check if it exists.
            Point location;
            bool sreenshot = FindBitmap(Properties.Resources.bmpScreenshot, bmpScreenshot, out location);

            // Check if it found the bitmap.
            //if (!sreenshot)
            //{
            //    MessageBox.Show("Couldn't find the button");
            //    return;
            //}

            // Move the mouse to login button.
            Cursor.Position = location;

            // Click.
            MouseClick();
        }

        private void ClickButton2()
        {
            /*
             *     [x] Snapshot of the whole screen.
             *     [x] Find the login button and check if it exists.
             *     [x] Move the mouse to login button.
             *     [ ] Click the login button.
             */

            // Takes a snapshot of the screen.
            Bitmap bmpScreenshot = Screenshot();

            // Makes the background of the form a screenshot of the screen.
            this.BackgroundImage = bmpScreenshot;

            // Find the login button and check if it exists.
            Point location;
            bool sreenshot = FindBitmap(Properties.Resources.bmpScreenshot2, bmpScreenshot, out location);

            // Check if it found the bitmap.
            //if (!sreenshot)
            //{
            //    MessageBox.Show("Couldn't find the button");
            //    return;
            //}

            // Move the mouse to login button.
            Cursor.Position = location;

            // Click.
            MouseClick();
        }

        private void ClickButton3()
        {
            /*
             *     [x] Snapshot of the whole screen.
             *     [x] Find the login button and check if it exists.
             *     [x] Move the mouse to login button.
             *     [ ] Click the login button.
             */

            // Takes a snapshot of the screen.
            Bitmap bmpScreenshot = Screenshot();

            // Makes the background of the form a screenshot of the screen.
            this.BackgroundImage = bmpScreenshot;

            // Find the login button and check if it exists.
            Point location;
            bool sreenshot = FindBitmap(Properties.Resources.bmpScreenshot3, bmpScreenshot, out location);

            // Check if it found the bitmap.
            //if (!sreenshot)
            //{
            //    MessageBox.Show("Couldn't find the button");
            //    return;
            //}

            // Move the mouse to login button.
            Cursor.Position = location;

            // Click.
            MouseClick();
        }

        private void ClickButton4()
        {
            /*
             *     [x] Snapshot of the whole screen.
             *     [x] Find the login button and check if it exists.
             *     [x] Move the mouse to login button.
             *     [ ] Click the login button.
             */

            // Takes a snapshot of the screen.
            Bitmap bmpScreenshot = Screenshot();

            // Makes the background of the form a screenshot of the screen.
            this.BackgroundImage = bmpScreenshot;

            // Find the login button and check if it exists.
            Point location;
            bool sreenshot = FindBitmap(Properties.Resources.bmpScreenshot4, bmpScreenshot, out location);

            // Check if it found the bitmap.
            //if (!sreenshot)
            //{
            //    MessageBox.Show("Couldn't find the button");
            //    return;
            //}

            // Move the mouse to login button.
            Cursor.Position = location;

            // Click.
            MouseClick();
        }

        private void ClickButton5()
        {
            /*
             *     [x] Snapshot of the whole screen.
             *     [x] Find the login button and check if it exists.
             *     [x] Move the mouse to login button.
             *     [ ] Click the login button.
             */

            // Takes a snapshot of the screen.
            Bitmap bmpScreenshot = Screenshot();

            // Makes the background of the form a screenshot of the screen.
            this.BackgroundImage = bmpScreenshot;

            // Find the login button and check if it exists.
            Point location;
            bool sreenshot = FindBitmap(Properties.Resources.bmpScreenshot5, bmpScreenshot, out location);

            // Check if it found the bitmap.
            //if (!sreenshot)
            //{
            //    MessageBox.Show("Couldn't find the button");
            //    return;
            //}

            // Move the mouse to login button.
            Cursor.Position = location;

            // Click.
            MouseClick();
        }

        /// <summary>
        /// Simulates a mouse click.
        /// </summary>
        private void MouseClick()
        {
            mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep((new Random()).Next(20, 30));
            mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        }

        /// <summary>
        /// Takes a snapshot of the screen.
        /// </summary>
        /// <returns>A snapshot of the screen.</returns>
        private Bitmap Screenshot()
        {
            // This is where we will store a snapshot of the screen.
            Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            // Creates a graphics object so we can draw the screen in the bitmap (bmpScreenshot).
            Graphics g = Graphics.FromImage(bmpScreenshot);

            // Copy from screen into the bitmap we created.
            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            // Dispose the screen to prevent leak the memory.
            g.Dispose();

            // Return the screenshot.
            return bmpScreenshot;
        }

        /// <summary>
        /// Find the location of a bitmap within another bitmap and 
        /// return if it was successfully found.
        /// </summary>
        /// <param name="bmpNeedle">The image we want to find.</param>
        /// <param name="bmpHaystack">Where we want to search for the image.</param>
        /// <param name="location">Where we found the image.</param>
        /// <returns>If the bmpNeedle was found successfully.</returns>
        private bool FindBitmap(Bitmap bmpNeedle, Bitmap bmpHaystack, out Point location)
        {
            for (int outerX = 0; outerX < bmpHaystack.Width - bmpNeedle.Width; outerX++)
            {
                for (int outerY = 0; outerY < bmpHaystack.Height - bmpNeedle.Height; outerY++)
                {
                    for (int innerX = 0; innerX < bmpNeedle.Width; innerX++)
                    {
                        for (int innerY = 0; innerY < bmpNeedle.Height; innerY++)
                        {
                            Color cNeedle = bmpNeedle.GetPixel(innerX, innerY);
                            Color cHaystack = bmpHaystack.GetPixel(innerX + outerX, innerY + outerY);

                            if (cNeedle.R != cHaystack.R || cNeedle.G != cHaystack.G || cNeedle.B != cHaystack.B)
                            {
                                goto notFound;
                            }
                        }
                    }
                    location = new Point(outerX, outerY);
                    return true;
                notFound:
                    continue;
                }
            }
            location = Point.Empty;
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
