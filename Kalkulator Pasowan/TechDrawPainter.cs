using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kalkulator_Pasowan
{
    /// <summary>
    /// TechDrawPainter - obiiekt umożliwaiające malowanie obiektów graficznych programu
    /// między inymi rysunków technicznych 
    /// </summary>

    class TechDrawPainter
    {
        
        /// <summary>
        /// Properties 
        /// </summary>
        #region
        int pictureWidth = 434;
        int pictureHeight = 290;
        int fitPictureWidth = 0;
        int fitPictureHeight = 0;
        Pen pen = new Pen(Color.Red,1);
        #endregion

        /// <summary>
        /// Properites Pens and Brusches used to draw graphics
        /// </summary>
        #region
        Pen thinPen = new Pen(Color.Black, 1);
        Pen thickPen = new Pen(Color.Black, 2);
        HatchBrush hatchBrushShaft = new HatchBrush(HatchStyle.BackwardDiagonal,Color.Black, Color.Transparent);
        HatchBrush hatchBrushHole  = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Black, Color.Transparent);
        HatchBrush hatchBrushShaftFitField = new HatchBrush(HatchStyle.DiagonalCross, Color.Crimson, Color.Transparent);
        HatchBrush hatchBrushHoleFitField = new HatchBrush(HatchStyle.DiagonalCross, Color.Crimson, Color.Transparent);
        Pen shaftThinPenFitField = new Pen(Color.Crimson, 1);
        Pen holeThinPenFitField = new Pen(Color.Crimson, 1);
        #endregion



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

            int shaftDiameterInPixel = 150;
            int shaftLenghtInPixel = (int)(150 * 1.68 - 30);
            int offsetShaftPositionX = -50;
            int offsetShaftPositionY = +20;

            int beginOfCut = (int)(shaftDiameterInPixel / 1.68);
            int offsetForCutSymbolLine = 0;
            int cutSymbolWidth = 20;
            int cutSymbolHeight = (int)(cutSymbolWidth * 1.68);

            int borderDistance = 0;
            int offsetForSymetryLine = 15;

            graphics.Clear(Color.WhiteSmoke);
            setVariableOfDraws(ref shaftDiameterInPixel, ref shaftLenghtInPixel, ref offsetShaftPositionX, ref offsetShaftPositionY,ref offsetForSymetryLine, ref borderDistance);

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
            
            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2+ offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2+ offsetShaftPositionY);
            graphics.DrawLine(shaftPen, beginPoint.X, beginPoint.Y, beginPoint.X + shaftLenghtInPixel, beginPoint.Y);
            graphics.DrawLine(shaftPen, beginPoint.X, beginPoint.Y+shaftDiameterInPixel, beginPoint.X + shaftLenghtInPixel, beginPoint.Y+shaftDiameterInPixel);
            graphics.DrawLine(shaftPen, beginPoint.X+shaftLenghtInPixel, beginPoint.Y , beginPoint.X + shaftLenghtInPixel, beginPoint.Y + shaftDiameterInPixel);

            //Draw Symbol
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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
            graphics.DrawLine(dashedPen,
                beginPoint.X - offsetForSymetryLine,
                beginPoint.Y+shaftDiameterInPixel/2,
                beginPoint.X + offsetForSymetryLine + shaftLenghtInPixel,
                beginPoint.Y + shaftDiameterInPixel / 2);

        }
        public void drawHole(Graphics graphics)
        {
            //clear pictureBox
            graphics.Clear(Color.WhiteSmoke);

            //Local Variables
            int holeDiameterInPixel = 150;
            int holeLenghtInPixel = (int)(150 * 1.68 - 30);
            int offsetHolePositionX = -50;
            int offsetHolePositionY = +20;
            int borderDistance = 20;
            int offsetForSymetryLine = 15;

            //Rewrite Variables
            setVariableOfDraws(ref holeDiameterInPixel,ref holeLenghtInPixel, ref offsetHolePositionX, ref offsetHolePositionY, ref offsetForSymetryLine, ref borderDistance);

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
            int minimalWidthofToleranceFiledInPX = 1;
            int maximallWidthofToleranceFiledInPX = 1000;

            setVariableOfDraws(ref shaftDiameterInPixel, ref shaftLenghtInPixel, ref offsetShaftPositionX, ref offsetShaftPositionY);
            scaleFactorPosiotion = (double)(shaftDiameterInPixel) * 10 / 1000 / nominalDimmension;
            scaleFactorWidth = (double)(shaftDiameterInPixel) * 10 / 1000/nominalDimmension;
            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2 + offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2 + offsetShaftPositionY);

            int toleranceFieldWidth = (int)((upperDeviation - lowerDeviation) * scaleFactorWidth);
            int toleranceFieldPosition = (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion);
            if (toleranceFieldWidth < minimalWidthofToleranceFiledInPX)
            {
                //toleranceFieldPosition = toleranceFieldPosition - (minimalWidthofToleranceFiledInPX - toleranceFieldWidth);
                toleranceFieldWidth = minimalWidthofToleranceFiledInPX;
            }
            if (toleranceFieldWidth > maximallWidthofToleranceFiledInPX)
            {
                //toleranceFieldPosition = toleranceFieldPosition + (toleranceFieldWidth - maximallWidthofToleranceFiledInPX);
                toleranceFieldWidth = maximallWidthofToleranceFiledInPX;
            }


            Pen pen = new Pen(Color.Red,1);
            
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross,Color.Crimson,Color.Transparent);
            graphics.FillRectangle(hatchBrush, beginPoint.X, toleranceFieldPosition, shaftLenghtInPixel, toleranceFieldWidth);
            graphics.DrawRectangle(pen, beginPoint.X , toleranceFieldPosition, shaftLenghtInPixel, toleranceFieldWidth);
            
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

            setVariableOfDraws(ref shaftDiameterInPixel, ref shaftLenghtInPixel, ref offsetShaftPositionX, ref offsetShaftPositionY);

            Pen pen = new Pen(Color.Red, 1);
            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2 + offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2 + offsetShaftPositionY);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.Crimson, Color.Transparent);
            graphics.FillRectangle(hatchBrush, beginPoint.X, (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion), shaftLenghtInPixel, (int)((upperDeviation - lowerDeviation) * scaleFactorWidth));
            graphics.DrawRectangle(pen, beginPoint.X, (int)(beginPoint.Y - upperDeviation * scaleFactorPosiotion), shaftLenghtInPixel, (int)((upperDeviation - lowerDeviation) * scaleFactorWidth));

        }
        public void drawRegularTolerationField(Graphics graphics, double nominalDimmension, double upperDeviation, double lowerDeviation)
        {
            int shaftDiameterInPixel = 150;
            int shaftLenghtInPixel = (int)(150 * 1.68 - 30);
            int offsetShaftPositionX = -50;
            int offsetShaftPositionY = +20;


            setVariableOfDraws(ref shaftDiameterInPixel, ref shaftLenghtInPixel, ref offsetShaftPositionX, ref offsetShaftPositionY);

            Pen pen = new Pen(Color.Red, 1);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.Crimson, Color.Transparent);
            int tolerationFieldWidth = 40;


            Point beginPoint = new Point((pictureWidth - shaftLenghtInPixel) / 2 + offsetShaftPositionX, (pictureHeight - shaftDiameterInPixel) / 2 + offsetShaftPositionY);
            int offsetOfPositionOfToleationField = 0;

            if(upperDeviation<0 && lowerDeviation <0)
            {
                offsetOfPositionOfToleationField = (int)(0.66*tolerationFieldWidth); ;
            }
            else if(upperDeviation == 0 && lowerDeviation <0)
            {
                offsetOfPositionOfToleationField = 0;
            }
            else if(upperDeviation>0 && lowerDeviation <0 && upperDeviation < -lowerDeviation)
            {
                offsetOfPositionOfToleationField = (int)(-0.33 * tolerationFieldWidth);
            }
            else if(upperDeviation > 0 && lowerDeviation < 0 && upperDeviation == -lowerDeviation)
            {
                offsetOfPositionOfToleationField = (int)(-0.5 * tolerationFieldWidth);
            }
            else if (upperDeviation > 0 && lowerDeviation < 0 && upperDeviation > -lowerDeviation)
            {
                offsetOfPositionOfToleationField = (int)(-0.65 * tolerationFieldWidth);
            }
            else if (upperDeviation > 0 && lowerDeviation == 0)
            {
                offsetOfPositionOfToleationField = (int)(-tolerationFieldWidth);
            }
            else if (upperDeviation > 0 && lowerDeviation > 0)
            {
                offsetOfPositionOfToleationField = (int)(-1.5 * tolerationFieldWidth);
            }

            graphics.FillRectangle(hatchBrush, beginPoint.X, (int)(beginPoint.Y + offsetOfPositionOfToleationField), shaftLenghtInPixel, tolerationFieldWidth);
            graphics.DrawRectangle(pen, beginPoint.X, (int)(beginPoint.Y + offsetOfPositionOfToleationField), shaftLenghtInPixel, tolerationFieldWidth);

            //create needed pens
            Pen thinPen = new Pen(Color.Black, 1);
            thinPen.EndCap = LineCap.Round;
            thinPen.StartCap = LineCap.Round;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //needed variables
            int generalOffset = 15;
            int offsetBeetwenDimensions = 40;
            int baseLineLength = 4 * offsetBeetwenDimensions+ generalOffset;
            int nominalDimensionLineLength = 2 * offsetBeetwenDimensions+ generalOffset;
            int lowerDeviationLineLength = 4 * offsetBeetwenDimensions+ generalOffset;
            int upperDeviationLineLength = 3 * offsetBeetwenDimensions+ generalOffset;

            //draw base line
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel, beginPoint.Y + shaftDiameterInPixel, beginPoint.X + shaftLenghtInPixel+ baseLineLength,  beginPoint.Y + shaftDiameterInPixel);

            //draw nomian dimension line
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel, beginPoint.Y , beginPoint.X + shaftLenghtInPixel + nominalDimensionLineLength, beginPoint.Y );

            //draw deaviations lines
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel, beginPoint.Y + offsetOfPositionOfToleationField+tolerationFieldWidth, beginPoint.X + shaftLenghtInPixel + upperDeviationLineLength, beginPoint.Y + offsetOfPositionOfToleationField + tolerationFieldWidth);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel, beginPoint.Y + offsetOfPositionOfToleationField, beginPoint.X + shaftLenghtInPixel + lowerDeviationLineLength, beginPoint.Y + offsetOfPositionOfToleationField);

            //draw nominal dimension
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(0, 0, -2, -6);
            graphicsPath.AddLine(0, 0, 2, -6);  
            thinPen.CustomStartCap = new CustomLineCap(null, graphicsPath);
            thinPen.CustomEndCap = new CustomLineCap(null, graphicsPath);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel + 2 * offsetBeetwenDimensions, beginPoint.Y + shaftDiameterInPixel, beginPoint.X + shaftLenghtInPixel + 2 * offsetBeetwenDimensions, beginPoint.Y);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel + 3 * offsetBeetwenDimensions, beginPoint.Y + shaftDiameterInPixel, beginPoint.X + shaftLenghtInPixel + 3 * offsetBeetwenDimensions, beginPoint.Y + offsetOfPositionOfToleationField+ tolerationFieldWidth);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel + 3 * offsetBeetwenDimensions, beginPoint.Y + offsetOfPositionOfToleationField, beginPoint.X + shaftLenghtInPixel + 3 * offsetBeetwenDimensions, beginPoint.Y + offsetOfPositionOfToleationField + tolerationFieldWidth);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel + 4 * offsetBeetwenDimensions, beginPoint.Y + shaftDiameterInPixel, beginPoint.X + shaftLenghtInPixel + 4 * offsetBeetwenDimensions, beginPoint.Y + offsetOfPositionOfToleationField);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel + 1 * offsetBeetwenDimensions, beginPoint.Y, beginPoint.X + shaftLenghtInPixel + 1 * offsetBeetwenDimensions, beginPoint.Y + offsetOfPositionOfToleationField);
            graphics.DrawLine(thinPen, beginPoint.X + shaftLenghtInPixel + 1 * offsetBeetwenDimensions, beginPoint.Y, beginPoint.X + shaftLenghtInPixel + 1 * offsetBeetwenDimensions, beginPoint.Y + offsetOfPositionOfToleationField + tolerationFieldWidth);
        }
        public void changeNominalDimension()
        {

        }
        private void setVariableOfDraws(ref int diameter, ref int lenth, ref int offsetX, ref int offsetY, ref int offsetSymetry, ref int offsetBorder)
        {
            diameter = 150;
            lenth = (int)(150 * 1.68 - 30)-100;
            offsetX = -50;
            offsetY = +20;
            offsetSymetry = +15;
            offsetBorder = +15;
        }
        private void setVariableOfDraws(ref int diameter, ref int lenth, ref int offsetX, ref int offsetY)
        {
            diameter = 150;
            lenth = (int)(150 * 1.68 - 30) - 100;
            offsetX = -50;
            offsetY = +20;
        }
        public void prepareFitCanvas(int width, int height)
        {
            fitPictureWidth = width;
            fitPictureHeight = height;
        }
        public void drawFitField(Graphics graphics, ToleratedSize shaft,ToleratedSize Hole)
        {
            graphics.Clear(Color.WhiteSmoke);

            ///
            /// Drawing shaft on fit field

            int shaftDiameterInPixel = 100;
            int shaftLenghtInPixel = (int)(120 * 1.68- 30);
            int shaftOffsetPositionX = +250;
            int shaftOffsetPositionY = 0;
            int beginOfCut = (int)(shaftDiameterInPixel / 1.68);
            int offsetForCutSymbolLine = +10;
            int cutSymbolWidth = 20;
            int cutSymbolHeight = (int)(cutSymbolWidth * 1.68);


            graphics.DrawLine(thickPen, shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY, shaftLenghtInPixel+shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY);
            graphics.DrawLine(thickPen, shaftLenghtInPixel + shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY, shaftLenghtInPixel + shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY + shaftDiameterInPixel);
            //graphic.DrawRectangle(thinPen, shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY, shaftLenghtInPixel, shaftDiameterInPixel);
            //graphic.FillRectangle(hatchBrushShaft, shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY, shaftLenghtInPixel, shaftDiameterInPixel);

            Point beginPoint = new Point(shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY);
           

            //Draw Symbol
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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

            ///
            /// Drawing Hole on fit field

            int holeDiameterInPixel = 100;
            int holeLenghtInPixel = (int)(120 * 1.68 - 30);
            int holeOffsetPositionX = +450;
            int holeOffsetPositionY = 0;
            int holeBorderOffset = 20;

            graphics.DrawLine(thickPen, holeOffsetPositionX, fitPictureHeight / 2 + holeOffsetPositionY, holeOffsetPositionX, holeBorderOffset);
            graphics.DrawLine(thickPen, holeOffsetPositionX, fitPictureHeight / 2 + holeOffsetPositionY, holeOffsetPositionX + holeLenghtInPixel, fitPictureHeight / 2 + holeOffsetPositionY);
            graphics.DrawLine(thickPen, holeOffsetPositionX+holeLenghtInPixel, fitPictureHeight / 2 + holeOffsetPositionY, holeOffsetPositionX + holeLenghtInPixel, holeBorderOffset);
            if(holeOffsetPositionX>=shaftOffsetPositionX+shaftLenghtInPixel)
                graphics.DrawLine(thickPen, holeOffsetPositionX, fitPictureHeight / 2 + holeOffsetPositionY, holeOffsetPositionX, fitPictureHeight - holeBorderOffset);
            if (holeOffsetPositionX+holeLenghtInPixel>= shaftOffsetPositionX + shaftLenghtInPixel)
                graphics.DrawLine(thickPen, holeOffsetPositionX+ holeLenghtInPixel, fitPictureHeight / 2 + holeOffsetPositionY, holeOffsetPositionX+ holeLenghtInPixel, fitPictureHeight - holeBorderOffset);
            graphics.FillRectangle(hatchBrushHole, holeOffsetPositionX, holeBorderOffset, holeLenghtInPixel, fitPictureHeight / 2-holeBorderOffset);


            ///
            /// Drawing tolerationField for shaft

            int temporaryOffset = 20;
            double temporaryScale = .3;
            graphics.DrawRectangle(shaftThinPenFitField, shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY - temporaryOffset, shaftLenghtInPixel, (int)(shaftDiameterInPixel *temporaryScale));
            graphics.FillRectangle(hatchBrushShaftFitField, shaftOffsetPositionX, fitPictureHeight / 2 + shaftOffsetPositionY - temporaryOffset, shaftLenghtInPixel, (int)(shaftDiameterInPixel*temporaryScale));

            ///
            /// Drawing tolerationField for hole

            int temporaryOffset2 = 0;
            double temporaryScale2 = .45;
            graphics.DrawRectangle(holeThinPenFitField, holeOffsetPositionX, fitPictureHeight / 2 + holeOffsetPositionY - temporaryOffset2, holeLenghtInPixel, (int)(holeDiameterInPixel * temporaryScale2));
            graphics.FillRectangle(hatchBrushHoleFitField, holeOffsetPositionX, fitPictureHeight / 2 + holeOffsetPositionY - temporaryOffset2, holeLenghtInPixel, (int)(holeDiameterInPixel * temporaryScale2));


        }
    }

}
