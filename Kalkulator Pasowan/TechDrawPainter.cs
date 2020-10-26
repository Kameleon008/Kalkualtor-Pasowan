using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kalkulator_Pasowan
{
    class TechDrawPainter
    {
        int pictureWidth = 434;
        int pictureHeight = 290;
        Pen pen = new Pen(Color.Red,1);
        

        public TechDrawPainter()
        {
           
        }

        public TechDrawPainter(int heightOfPuctureBox, int widthOfPictureBox)
        {

        }

        public void clearDraw(Graphics graphics)
        {
            graphics.Clear(Color.White);
        }
        public void drawRandomLine(Graphics graphics)
        {
            //428; 290
            Random random = new Random();
            Pen pen = new Pen(Color.Red, 3);
            Point point1 = new Point(random.Next(0,428),random.Next(0, 290));
            Point point2 = new Point(random.Next(0, 428), random.Next(0, 290));
            graphics.DrawLine(pen, point1, point2);
        }
        public void drawShaft(Graphics graphics)
        {
            graphics.Clear(Color.WhiteSmoke);

            //CreatePen to draw normal lines
            Pen shaftPen = new Pen(Color.Black, 2);

            //Create Pen for drowin dashed lines
            Pen dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            dashedPen.DashPattern = new float[] { 30, 7, 2, 7 };
            dashedPen.DashOffset = 10;

            //Create Pen fo thinLines
            Pen thinPen = new Pen(Color.Black, 1);


            //Draw shaft
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            int shaftDiameterInPixel = 150;
            int shaftLenghtInPixel = (int)(150*1.68-30);
            int offsetShaftPositionX = -50;
            int offsetShaftPositionY = +20;
            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2+ offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2+ offsetShaftPositionY);
            graphics.DrawLine(shaftPen, beginPoint.X, beginPoint.Y, beginPoint.X + shaftLenghtInPixel, beginPoint.Y);
            graphics.DrawLine(shaftPen, beginPoint.X, beginPoint.Y+shaftDiameterInPixel, beginPoint.X + shaftLenghtInPixel, beginPoint.Y+shaftDiameterInPixel);
            graphics.DrawLine(shaftPen, beginPoint.X+shaftLenghtInPixel, beginPoint.Y , beginPoint.X + shaftLenghtInPixel, beginPoint.Y + shaftDiameterInPixel);

            //Draw Symbol
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int beginOfCut = (int)(shaftDiameterInPixel / 1.68);
            int offsetForCutSymbolLine = 0;
            int cutSymbolWidth = 20;
            int cutSymbolHeight = (int)(cutSymbolWidth * 1.68);
            Point[] cutSymbolPoints =
            {
                new Point(beginPoint.X,beginPoint.Y-offsetForCutSymbolLine),
                new Point(beginPoint.X,beginPoint.Y+beginOfCut),
                new Point(beginPoint.X+cutSymbolWidth/2,beginPoint.Y+beginOfCut+cutSymbolHeight/4),
                new Point(beginPoint.X-cutSymbolWidth/2,beginPoint.Y+beginOfCut+cutSymbolHeight/4+cutSymbolHeight/2),
                new Point(beginPoint.X,beginPoint.Y+beginOfCut+cutSymbolHeight/4+cutSymbolHeight/2+cutSymbolHeight/4),
                new Point(beginPoint.X,beginPoint.Y+offsetForCutSymbolLine+shaftDiameterInPixel),
            };
            graphics.DrawLines(thinPen, cutSymbolPoints);


            //Draw line of symetry of shaft
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int offsetForSymetryLine = 15;
            graphics.DrawLine(dashedPen,
                beginPoint.X - offsetForSymetryLine,
                beginPoint.Y+shaftDiameterInPixel/2,
                beginPoint.X + offsetForSymetryLine + shaftLenghtInPixel,
                beginPoint.Y + shaftDiameterInPixel / 2);

        }
        public void drawHole(Graphics graphics)
        {
            graphics.Clear(Color.WhiteSmoke);

            //Local Variables

            //Create Pen to drawa Hole
            Pen holePen = new Pen(Color.Black,2);

            //Create Pen to draw Dashed Line like symetry line
            Pen dashedPen = new Pen(Color.Black,1);
            dashedPen.DashCap = DashCap.Round;
            dashedPen.DashPattern = new float[] { 30, 7, 2, 7 };
            dashedPen.DashOffset = 10;

            //Create Pen to draw thin lines
            Pen thinPen = new Pen(Color.Black,1);

            //Draw Hole
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            int holeDiameterInPixel = 150;
            int holeLenghtInPixel = (int)(150 * 1.68 - 30);
            int offsetHolePositionX = -50;
            int offsetHolePositionY = +20;
            int borderDistance = 20;
            Point beginPoint = new Point((pictureWidth - holeLenghtInPixel) / 2 + offsetHolePositionX, (pictureHeight - holeDiameterInPixel) / 2 + offsetHolePositionY);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Black, Color.Transparent);
            graphics.DrawLine(holePen, beginPoint.X, beginPoint.Y, beginPoint.X, borderDistance);
            graphics.DrawLine(holePen, beginPoint.X, beginPoint.Y, beginPoint.X + holeLenghtInPixel, beginPoint.Y);
            graphics.DrawLine(holePen, beginPoint.X+ holeLenghtInPixel, beginPoint.Y, beginPoint.X+ holeLenghtInPixel, borderDistance);
            graphics.DrawLine(holePen, beginPoint.X, beginPoint.Y+holeDiameterInPixel, beginPoint.X, pictureHeight- borderDistance);
            graphics.DrawLine(holePen, beginPoint.X, beginPoint.Y + holeDiameterInPixel, beginPoint.X + holeLenghtInPixel, beginPoint.Y+holeDiameterInPixel);
            graphics.DrawLine(holePen, beginPoint.X + holeLenghtInPixel, beginPoint.Y + holeDiameterInPixel, beginPoint.X + holeLenghtInPixel, pictureHeight - borderDistance);
            graphics.FillRectangle(hatchBrush, beginPoint.X, borderDistance, holeLenghtInPixel, beginPoint.Y - borderDistance);
            graphics.FillRectangle(hatchBrush, beginPoint.X, beginPoint.Y + holeDiameterInPixel, holeLenghtInPixel, pictureHeight - beginPoint.Y - holeDiameterInPixel - borderDistance);
            graphics.DrawLine(holePen, beginPoint.X, beginPoint.Y, beginPoint.X, beginPoint.Y + holeDiameterInPixel);
            graphics.DrawLine(holePen, beginPoint.X+holeLenghtInPixel, beginPoint.Y, beginPoint.X+ holeLenghtInPixel, beginPoint.Y + holeDiameterInPixel);

            //Draw line of symetry of shaft
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int offsetForSymetryLine = 15;
            graphics.DrawLine(dashedPen,
                beginPoint.X - offsetForSymetryLine,
                beginPoint.Y + holeDiameterInPixel / 2,
                beginPoint.X + offsetForSymetryLine + holeLenghtInPixel,
                beginPoint.Y + holeDiameterInPixel / 2);
        }
        public void drawShaftToleranceField(Graphics graphics, double nominalDimmension, double upperDeviation, double lowerDeviation)
        {
            //graphicsShaft.Clear(Color.WhiteSmoke);
            int shaftDiameterInPixel = 150;
            int shaftLenghtInPixel = (int)(150 * 1.68 - 30);
            int offsetShaftPositionX = -50;
            int offsetShaftPositionY = +20;
            double scaleFactorPosiotion = 0.1;
            double scaleFactorWidth =0.1;
            ;
            Pen pen = new Pen(Color.Red,1);
            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2 + offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2 + offsetShaftPositionY);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross,Color.Crimson,Color.Transparent);
            graphics.FillRectangle(hatchBrush, beginPoint.X, (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion), shaftLenghtInPixel, (int)((upperDeviation-lowerDeviation) * scaleFactorWidth));
            graphics.DrawRectangle(pen, beginPoint.X , (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion), shaftLenghtInPixel, (int)((upperDeviation - lowerDeviation) * scaleFactorWidth));
            
        }
        public void drawHoleToleranceField(Graphics graphics, double nominalDimmension, double upperDeviation, double lowerDeviation)
        {
            //graphicsShaft.Clear(Color.WhiteSmoke);
            int shaftDiameterInPixel = 150;
            int shaftLenghtInPixel = (int)(150 * 1.68 - 30);
            int offsetShaftPositionX = -50;
            int offsetShaftPositionY = +20;
            double scaleFactorPosiotion = 0.1;
            double scaleFactorWidth = 0.1;
            ;
            Pen pen = new Pen(Color.Red, 1);
            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2 + offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2 + offsetShaftPositionY);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.Crimson, Color.Transparent);
            graphics.FillRectangle(hatchBrush, beginPoint.X, (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion), shaftLenghtInPixel, (int)((upperDeviation - lowerDeviation) * scaleFactorWidth));
            graphics.DrawRectangle(pen, beginPoint.X, (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion), shaftLenghtInPixel, (int)((upperDeviation - lowerDeviation) * scaleFactorWidth));

        }
        public void changeNominalDimension()
        {

        }
        private void fillTolearanceFieldWithCrossLines()
        {

        }
    }

}
