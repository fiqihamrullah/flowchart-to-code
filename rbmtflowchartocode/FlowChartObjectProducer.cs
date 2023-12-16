using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;

namespace rbmtflowchartocode
{
    class FlowChartObjectProducer
    {
        public FlowChartObjectProducer()
        {

        }

        public static FlowObject Create( Selector selectortype,SubType subtype)
        {
            FlowObject flowobject = new FlowObject(selectortype.GetSelectedObjectType());
            flowobject.SetSubType(subtype);
            if (flowobject.GetObjectType()== ObjectType.Rectangle)
            {
                flowobject.SetBrushColor(new SolidBrush(Color.Gold) );
                flowobject.SetPenStyle(new SolidBrush(Color.Orange), 4);
             
                flowobject.SetSize(300, 100);
                flowobject.SetValue("...");

            }
            else if (flowobject.GetObjectType() == ObjectType.RoundRect)
            {
                flowobject.SetBrushColor(new SolidBrush(Color.CornflowerBlue));
                flowobject.SetPenStyle(new SolidBrush(Color.Blue), 4);
                flowobject.SetSize(300, 100);
                flowobject.SetRadius(30);
                flowobject.SetValue("START");

            }
            else if (flowobject.GetObjectType() == ObjectType.Parallelogram)
            {
                flowobject.SetBrushColor(new SolidBrush(Color.LightBlue));
                flowobject.SetPenStyle(new SolidBrush(Color.DodgerBlue), 4);
                flowobject.SetSize(300, 100);
                flowobject.SetValue("...");

            }
            else if (flowobject.GetObjectType() == ObjectType.Diamond)
            {
                flowobject.SetBrushColor(new SolidBrush(Color.GreenYellow));
                flowobject.SetPenStyle(new SolidBrush(Color.DarkGreen), 4);
                flowobject.SetSize(200, 200);
                flowobject.SetValue("...");
            }else if (flowobject.GetObjectType() == ObjectType.DiamondEllipse)
            {
                flowobject.SetBrushColor(new SolidBrush(Color.GreenYellow));
                flowobject.SetPenStyle(new SolidBrush(Color.DarkGreen), 4);
                flowobject.SetSize(200, 200);
                flowobject.SetValue("...");
            }
            flowobject.SetHoverPenStyle(new SolidBrush(Color.Red), 8);
            return flowobject;
        }
    }
}
