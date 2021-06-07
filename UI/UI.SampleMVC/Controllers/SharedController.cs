using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult _GetCaptcha()
        {
            string[] letter =
                new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m" };

            Random random = new Random();//随机数

            Bitmap board = new Bitmap(100, 40);//画板
            Graphics g = Graphics.FromImage(board);//图
            g.Clear(Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        ));

            //乱线和点
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(
                    new Pen(
                        Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        )
                    ),
                    new Point(random.Next(100), random.Next(40)),
                    new Point(random.Next(100), random.Next(40)));
                board.SetPixel(random.Next(100), random.Next(40), Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        ));
            }

            //字母
            string letters = letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)];
            Session["Captcha"] = letters;

            g.DrawString(letters,
               new Font("Tahoma", 25),
               new SolidBrush(Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        )),
               new PointF(1, 0)
               );

            //保存到流中
            MemoryStream stream = new MemoryStream();
            board.Save(stream, ImageFormat.Jpeg);
            return File(stream.ToArray(), "image/png");
        }
    }
}