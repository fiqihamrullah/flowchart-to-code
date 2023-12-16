using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rbmtflowchartocode
{
    class DiagramMapper
    {
        private Diagram diagram;
        private SplitterPanel spanel;
        private int PADDING_TOP_BOTTOM = 5;
        private int PADDING_BETWEEN_OBJECT = 50;

        private double heightratio;


        private bool bRight,bLeft;

        public DiagramMapper(Diagram diagram,SplitterPanel spanel)
        {
            this.diagram = diagram;
            this.spanel = spanel;
            heightratio = 1;
        }

        public void MapObject()
        {
            int width = spanel.Width/2;
            int height = spanel.Height;      
            //spanel.AutoScrollMinSize = new System.Drawing.Size(1000, 3000);
          
            
            int centerY = PADDING_TOP_BOTTOM;
           
            for (int i = 0; i < diagram.GetObjectCount(); i++)
            {
                FlowObject flowobject = diagram.GetObjects(i);
                int centerX = width - (flowobject.GetNormalSize().Width / 2);
                // flowobject.setPosition(centerX, centerY);
                if (flowobject.GetObjectType() == ObjectType.Diamond)
                {
                    centerY += flowobject.GetNormalSize().Height*3; 
                }else if (flowobject.GetObjectType() == ObjectType.DiamondEllipse)
                {
                    centerY += flowobject.GetNormalSize().Height + (100) ;
                    //System.Diagnostics.Trace.WriteLine("TES");
                }
                else
                {
                    centerY += flowobject.GetNormalSize().Height;// +PADDING_BETWEEN_OBJECT;
                }

                if (i > 0)
                {
                    centerY += PADDING_BETWEEN_OBJECT;
                }
            
            }



            //centerY = 0;

            double ratio = (double)(centerY + PADDING_TOP_BOTTOM) / height;
            centerY = (int)(PADDING_TOP_BOTTOM / ratio);

            for (int i = 0; i < diagram.GetObjectCount(); i++)
            {
                FlowObject flowobject = diagram.GetObjects(i);
                int w = flowobject.GetNormalSize().Width;
                int h = (int)(flowobject.GetNormalSize().Height / ratio);  
              //  System.Diagnostics.Trace.WriteLine("Rasio " + h.ToString());
                flowobject.SetSizeScaled(w, h);

                if (flowobject.rightObjectNo != null)
                {
                    int wx = flowobject.rightObjectNo.GetNormalSize().Width;
                    int hx = (int)(flowobject.rightObjectNo.GetNormalSize().Height / ratio);
                    //  System.Diagnostics.Trace.WriteLine("Rasio " + h.ToString());
                    flowobject.rightObjectNo.SetSizeScaled(wx, hx);
                    //System.Diagnostics.Trace.WriteLine("Adooooooooooooooooo");
                }

                if (flowobject.leftObjectYes  != null)
                {
                    int wx = flowobject.leftObjectYes.GetNormalSize().Width;
                    int hx = (int)(flowobject.leftObjectYes.GetNormalSize().Height / ratio);
                    //  System.Diagnostics.Trace.WriteLine("Rasio " + h.ToString());
                    flowobject.leftObjectYes.SetSizeScaled(wx, hx);
                    //System.Diagnostics.Trace.WriteLine("Adooooooooooooooooo");
                }


            }

            int newPad =(int) (PADDING_BETWEEN_OBJECT/ratio);

            for (int i = 0; i < diagram.GetObjectCount(); i++)
            {
                FlowObject flowobject = diagram.GetObjects(i);                 
                int centerX = width-(flowobject.GetSize().Width/2);
                if (flowobject.GetObjectType() == ObjectType.DiamondEllipse)
                {
                    flowobject.SetPosition(centerX, centerY+(int)(100/ratio));
                }
                else
                {
                    flowobject.SetPosition(centerX, centerY);
                }


                if (flowobject.GetObjectType() == ObjectType.Diamond)
                {
                    if (flowobject.rightObjectNo != null)
                    {
                        int myCenterX = centerX + (flowobject.rightObjectNo.GetSize().Width / 2) + 50;
                        int myCenterY = centerY + (flowobject.rightObjectNo.GetSize().Height / 2);
                        flowobject.rightObjectNo.SetPosition(myCenterX, (int)(myCenterY + 200 / ratio));
                    }
                }else if (flowobject.GetObjectType() == ObjectType.DiamondEllipse)
                {
                    if (flowobject.rightObjectNo != null)
                    {
                        int myCenterX = centerX + (flowobject.rightObjectNo.GetSize().Width / 2) + 50;
                        int myCenterY = centerY + (flowobject.rightObjectNo.GetSize().Height / 2);
                        flowobject.rightObjectNo.SetPosition(myCenterX, (int)(myCenterY + (25 / ratio)));
                    }
                }

                    if (flowobject.leftObjectYes != null)
                {
                    int myCenterX = centerX - (flowobject.leftObjectYes.GetSize().Width / 2) -150;
                    int myCenterY = centerY + (flowobject.leftObjectYes.GetSize().Height / 2);
                    flowobject.leftObjectYes.SetPosition(myCenterX, (int) (myCenterY + 200 / ratio));
                }

                if (flowobject.GetObjectType()==ObjectType.Diamond)
                {
                    centerY += (int)(flowobject.GetSize().Height*3 + newPad);
                }else if (flowobject.GetObjectType() == ObjectType.DiamondEllipse)
                {
                    centerY += (int)(flowobject.GetSize().Height + (100/ratio) + newPad);
                }
                else
                {
                    centerY += (int)(flowobject.GetSize().Height + newPad);
                } 

            }
            heightratio = ratio;
                 

        }

        public bool IsRightPosition()
        {
            return bRight;
        }

        public bool IsLeftPosition()
        {
            return bLeft;
        }

        public bool IsNetralPosition()
        {
            return ((bRight == false) && (bLeft == false));
        }

        public double GetRatio()
        {
            return heightratio;
        }

        public FlowObject GetFlowObject(int x,int y)
        {
           // System.Diagnostics.Trace.WriteLine("i :" + x.ToString() + ",j : " + y.ToString()); 
            FlowObject flowobject = null;
            bRight = false;bLeft = false;
            for (int i = 0; i < diagram.GetObjectCount(); i++)
            {
                FlowObject fobject = diagram.GetObjects(i);
                fobject.GoNormal();

                //  System.Diagnostics.Trace.WriteLine("x:" + fobject.getPosition().X.ToString()  + ",j : " + fobject.getPosition().Y.ToString()); 
                if (fobject.GetPosition().X < x && x < fobject.GetPosition().X + fobject.GetSize().Width)
                {
                    if (fobject.GetPosition().Y < y && y < fobject.GetPosition().Y + fobject.GetSize().Height)
                    {
                        flowobject = fobject;
                        System.Diagnostics.Trace.WriteLine("Kena Atas");
                        break;
                    }
                }

                if (fobject.GetObjectType() == ObjectType.DiamondEllipse)
                {
                    double ratio = GetRatio();
                    if (fobject.GetPosition().X < x && x < fobject.GetPosition().X + fobject.GetSize().Width)
                    {
                        
                        if (fobject.GetPosition().Y-(100/ratio) < y && y < (fobject.GetPosition().Y - (100 / ratio)) + fobject.GetSize().Height)
                        {
                            flowobject = fobject;
                            System.Diagnostics.Trace.WriteLine("Kena Khusus Looop");
                            break;
                        }
                    }

                    int myx = fobject.GetPosition().X + fobject.GetSize().Width;

                    if (myx < x && x < (myx+ (100/ratio)))
                    {                         
                        if (fobject.GetPosition().Y - (100 / ratio) < y && y < (fobject.GetPosition().Y - (100 / ratio)) + fobject.GetSize().Height)
                        {
                            
                            flowobject = fobject;
                            bRight = true;
                            System.Diagnostics.Trace.WriteLine("Kena bagian No Looop");
                            break;
                        }
                    }





                }


                if (fobject.GetObjectType()==ObjectType.Diamond)
                    {
                        if ((fobject.GetPosition().X + fobject.GetSize().Width) < x && x < fobject.GetPositionNo().X)
                        {
                            if (fobject.GetPosition().Y < y && y < fobject.GetPositionNo().Y)
                            {
                                 //System.Diagnostics.Trace.WriteLine("Kanan");
                                flowobject = fobject;
                                bRight = true;
                                break;
                            } 
                        }


                        if(fobject.GetPosition().X  > x && x > fobject.GetPositionYes().X)
                        {
                            if (fobject.GetPosition().Y < y && y < fobject.GetPositionYes().Y)
                            {
                                // System.Diagnostics.Trace.WriteLine("Kiri");
                                flowobject = fobject;                         
                                bLeft = true;
                                break;
                            }
                        }

                     }



                    if (fobject.rightObjectNo != null)
                    {
                        FlowObject fobjectx = fobject.rightObjectNo;
                        fobjectx.GoNormal(); 
                        if (fobjectx.GetPosition().X < x && x < fobjectx.GetPosition().X + fobjectx.GetSize().Width)
                        {
                            if (fobjectx.GetPosition().Y < y && y < fobjectx.GetPosition().Y + fobjectx.GetSize().Height)
                            {
                                flowobject = fobjectx;
                               // System.Diagnostics.Trace.WriteLine("Kena Kanan");
                            }
                        }
                    }

                    if (fobject.leftObjectYes != null)
                    {
                        FlowObject fobjectx = fobject.leftObjectYes;
                        fobjectx.GoNormal();
                        if (fobjectx.GetPosition().X < x && x < fobjectx.GetPosition().X + fobjectx.GetSize().Width)
                        {
                            if (fobjectx.GetPosition().Y < y && y < fobjectx.GetPosition().Y + fobjectx.GetSize().Height)
                            {
                                flowobject = fobjectx;
                                System.Diagnostics.Trace.WriteLine("Kena Kiri");
                                //  break;
                            }
                        }
                    } 

            }

            return flowobject;
        }
    }
}
