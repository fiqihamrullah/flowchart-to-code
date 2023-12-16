using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;
using System.Text;

namespace rbmtflowchartocode
{
    class FlowChartDrawer
    {
        private Graphics canvas;
        private Diagram diagram;
        private Boolean bStart;

        private double ratio;

        public FlowChartDrawer(Graphics canvas,Diagram diagram,double ratio)
        {
            this.canvas = canvas ;
            this.diagram = diagram;
            bStart = false;

            this.ratio = ratio;
        }



        private   GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();
            

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            
            path.AddArc(arc, 180, 90);

             
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private Point[] CreateParallelogram(Rectangle bounds, int dist)
        {
            Point[] points = new Point[4];
            points[0] = new Point(bounds.X + dist, bounds.Y);
            int length = (int) Math.Sqrt(Math.Pow(dist, 2) + Math.Pow(bounds.Height, 2));

            points[1] = new Point(bounds.X, bounds.Y + length);


            points[2] = new Point(bounds.X +  bounds.Width, bounds.Y + length);

            points[3] = new Point(bounds.X + dist+ bounds.Width, bounds.Y );


            return points;
        }

        private Point[] CreateDiamond(Rectangle bounds)
        {
            Point[] points = new Point[4];
            points[0] = new Point(bounds.X + (bounds.Width/2), bounds.Y);
            points[1] = new Point(bounds.X, bounds.Y +(bounds.Height / 2));
            points[2] = new Point(bounds.X + (bounds.Width / 2), bounds.Y + bounds.Height);
            points[3] = new Point(bounds.X +  bounds.Width, bounds.Y + (bounds.Height/2));
            return points;
        }

        public void PaintDiagram()
        {
            canvas.Clear(Color.White);
            int arrowwidth =(int)( 20/ ratio);
            if (diagram != null)
            {
                for (int i = 0; i < diagram.GetObjectCount(); i++)
                {
                   
                    Draw(diagram.GetObjects(i));
                }

                int thickline = (int)(6 / ratio);

                for (int i = 0; i < diagram.GetObjectCount()-1; i++)
                {
                    FlowObject fobject = diagram.GetObjects(i);
                    FlowObject fobjectnext = diagram.GetObjects(i+1);
                    int xStart = fobject.GetPosition().X + (fobject.GetSize().Width / 2);
                    int yStart = fobject.GetPosition().Y + (fobject.GetSize().Height);
                    if (fobject.GetObjectType()==ObjectType.Diamond)
                    {
                        yStart = fobject.GetPosition().Y + ((fobject.GetSize().Height)*3);
                    }
                    

                    int yEnd = 0;

                    if (fobjectnext.GetObjectType() == ObjectType.DiamondEllipse)
                    {
                        int selisih = ((int)(100 / ratio));
                        yEnd = fobjectnext.GetPosition().Y - selisih;

                        Rectangle myRectangle = new Rectangle(fobjectnext.GetPosition().X, yEnd, fobjectnext.GetSize().Width, fobjectnext.GetSize().Height-selisih);
                        canvas.DrawEllipse(fobjectnext.GetPenStyle(), myRectangle);
                        canvas.FillEllipse(fobjectnext.GetBrush(), myRectangle);
                        canvas.DrawString("LOOP", new Font("verdana", (int)(16 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.White), xStart - (int)(40 / ratio), yEnd+(int)(40/ratio));

                        int loopstartX = fobjectnext.GetPosition().X + myRectangle.Width;
                        int loopendY = yEnd + (myRectangle.Height / 2);
                        canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(loopstartX, loopendY), new Point(loopstartX + selisih, loopendY));
                       // canvas.DrawString("No", new Font("verdana", (int)(8 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.Red), loopstartX, loopendY- (int)(20/ratio));
                        int loopendY2 = fobjectnext.GetPosition().Y + (fobjectnext.GetSize().Height/2);
                        canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(loopstartX, loopendY2), new Point(loopstartX + selisih, loopendY2));
                        canvas.DrawString("No", new Font("verdana", (int)(8 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.Red), loopstartX, loopendY2 - (int)(20 / ratio));
                       // if (fobjectnext.GetRightFlowObject() == null)
                        {
                            canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(loopstartX+selisih, loopendY), new Point(loopstartX + selisih, loopendY2));
                        }

                        int yEnd2 = fobjectnext.GetPosition().Y + (fobjectnext.GetSize().Height);
                        canvas.DrawString("Yes", new Font("verdana", (int)(8 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.Red), xStart + (int)(10 / ratio), yEnd2 + (int)(10 / ratio));

                        if (fobjectnext.rightObjectNo != null)
                            Draw(fobjectnext.rightObjectNo);
                    }
                    else
                    {
                        yEnd = fobjectnext.GetPosition().Y;
                    }

                    canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart + arrowwidth, yEnd - arrowwidth), new Point(xStart, yEnd));
                    canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart,yStart), new Point(xStart,yEnd ));
                    canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart - arrowwidth, yEnd - arrowwidth), new Point(xStart, yEnd));



                }
            }

        }

        public void Draw(FlowObject fobject)
        {
          
            ObjectType otype = fobject.GetObjectType();
            double ratio = (double)(fobject.GetNormalSize().Height) / fobject.GetSize().Height;

            if (otype == ObjectType.RoundRect)
            {
                Rectangle myRectangle = new Rectangle(fobject.GetPosition().X, fobject.GetPosition().Y, fobject.GetSize().Width, fobject.GetSize().Height);
                using (GraphicsPath path = RoundedRect(myRectangle, fobject.GetRadius()))
                {
                    canvas.DrawPath(fobject.GetPenStyle(), path);
                    canvas.FillPath(fobject.GetBrush(), path);
                }
            }
            else if (otype == ObjectType.Rectangle)
            {
                Rectangle myRectangle = new Rectangle(fobject.GetPosition().X, fobject.GetPosition().Y, fobject.GetSize().Width, fobject.GetSize().Height);
                canvas.DrawRectangle(fobject.GetPenStyle(), myRectangle);
                canvas.FillRectangle(fobject.GetBrush(), myRectangle);
            }
            else if (otype == ObjectType.Parallelogram)
            {
                Rectangle myRectangle = new Rectangle(fobject.GetPosition().X, fobject.GetPosition().Y, fobject.GetSize().Width, fobject.GetSize().Height);
                Point[] points = CreateParallelogram(myRectangle, 20);
                canvas.FillPolygon(fobject.GetBrush(), points);
                canvas.DrawPolygon(fobject.GetPenStyle(), points);
            }
            else if (otype == ObjectType.Diamond)
            {
                Rectangle myRectangle = new Rectangle(fobject.GetPosition().X, fobject.GetPosition().Y, fobject.GetSize().Width, fobject.GetSize().Height);
                Point[] points = CreateDiamond(myRectangle);
                canvas.FillPolygon(fobject.GetBrush(), points);
                canvas.DrawPolygon(fobject.GetPenStyle(), points);

                int thickline = (int)(6 / ratio);
                int length = (int)(60 / ratio);

                int spacelength = length / 4;
                int startstring = (int)(30 / ratio);

                //No
                int xStart = fobject.GetPosition().X + (fobject.GetSize().Width);
                int yStart = fobject.GetPosition().Y + (fobject.GetSize().Height/2);

                int xEnd = xStart + length;
                int yEnd = yStart;
                canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart, yStart), new Point(xEnd, yEnd));
                fobject.SetPositionNo(new Point(xEnd,yEnd));

                string expression = "NO";

                xStart = xStart + spacelength;
                yStart = yStart - startstring;

                canvas.DrawString(expression, new Font("verdana", (int)(16 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.Black), xStart, yStart);
                

                //Yes
                 xStart = fobject.GetPosition().X;
                 yStart = fobject.GetPosition().Y + (fobject.GetSize().Height / 2);

                 xEnd = xStart - length;
                 yEnd = yStart;

                 canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart, yStart), new Point(xEnd, yEnd));
                 fobject.SetPositionYes(new Point(xEnd, yEnd));

                 expression = "YES";

                 xStart = xStart - (spacelength*4);
                 yStart = yStart - startstring;

                canvas.DrawString(expression, new Font("verdana", (int)(16 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.Black), xStart, yStart);



                yStart = fobject.GetPositionNo().Y;
                yEnd = (yStart + (fobject.GetSize().Height * 3)) - (fobject.GetSize().Height / 2);

              
               // else
                {
                    xStart = fobject.GetPositionNo().X;                   
                    xEnd = xStart;
                   //
                    canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart, yStart), new Point(xEnd, yEnd));
                    if (fobject.rightObjectNo!=null )
                    Draw(fobject.rightObjectNo);
                }

               // if (fobject.leftObjectYes != null)
                
              //  else
                {
                    xStart = fobject.GetPositionYes().X;                  
                    xEnd = xStart;                    
                    canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart, yStart), new Point(xEnd, yEnd));
                    if (fobject.leftObjectYes != null)
                        Draw(fobject.leftObjectYes);
                }

                xStart = fobject.GetPositionYes().X;
                xEnd= fobject.GetPositionNo().X;
                yStart = yEnd;

                canvas.DrawLine(new Pen(new SolidBrush(Color.Black), thickline), new Point(xStart, yStart), new Point(xEnd, yEnd));


            }
            else if (otype == ObjectType.DiamondEllipse)
            {
                Rectangle myRectangle = new Rectangle(fobject.GetPosition().X, fobject.GetPosition().Y, fobject.GetSize().Width, fobject.GetSize().Height);
                Point[] points = CreateDiamond(myRectangle);
               

                canvas.FillPolygon(fobject.GetBrush(), points);
                canvas.DrawPolygon(fobject.GetPenStyle(), points);
               
            }
            
            String stradd = "";

            if (fobject.GetValue() == "START")
            {
                if (!bStart)
                {
                    // canvas.DrawString(fobject.GetValue(), new Font("verdana", (int)(16/ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.White), xcenter, ycenter);
                    stradd = fobject.GetValue();
                }
                else
                {
                    //canvas.DrawString("END", new Font("verdana", (int)(16/ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.White), xcenter, ycenter);
                    stradd = "END";
                }
                bStart = true;
            }
            else
            {
               
                if (fobject.GetSubType() == SubType.Input)
                {
                    stradd = "READ  " + fobject.GetValue();
                }
                else if (fobject.GetSubType() == SubType.Output)
                {
                    stradd = "PRINT "  + fobject.GetValue();
                }
                else if (fobject.GetSubType() == SubType.Conditional)
                {
                    stradd = "( " + fobject.GetValue() + " ) ";
                }
                else if (fobject.GetSubType() == SubType.Loop)
                {
                    stradd = "( " + fobject.GetValue() + " ) ";
                }else
                {
                    stradd = fobject.GetValue();
                }               
            }
            int half_w = fobject.GetSize().Width / 2;
            int xcenter = (fobject.GetPosition().X + half_w - ((int)(stradd.Length * (8 / ratio))) % half_w);
            int ycenter = fobject.GetPosition().Y + ((fobject.GetSize().Height) / 2) - ((int)(16 / ratio));
            canvas.DrawString(stradd, new Font("verdana", (int)(16 / ratio), FontStyle.Bold, GraphicsUnit.Point), new SolidBrush(Color.White), xcenter, ycenter);


        }

    }
}
