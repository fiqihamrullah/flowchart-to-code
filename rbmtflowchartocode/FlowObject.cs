using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;

namespace rbmtflowchartocode
{
    public enum SubType {Input,Output,Conditional,Loop,Other };
    class FlowObject
    {
        private Point position;
        private Point positionyes, positionno;
        private Size size;
        private ObjectType typeofObject;
        private SubType subtype;
        private Size sizeNormal;
        private Brush brushcolor;       
        private Pen pen;
        private Pen hoverpen;
        

        private int radius;

        private String val;
        private String datatype;


        public FlowObject rightObjectNo;
        public FlowObject leftObjectYes;
        public FlowObject UpperObject;



        public bool bHighLight;


        public FlowObject(ObjectType typeofObject)
        {
            this.typeofObject = typeofObject;
            rightObjectNo = null;
            leftObjectYes = null;
            datatype = "";
            val = "";
        }

        public void SetRightFlowObject(FlowObject rightObjectNo)
        {
            this.rightObjectNo = rightObjectNo;
        }

        public void SetLeftFlowObject(FlowObject leftObjectYes)
        {
            this.leftObjectYes = leftObjectYes;
        }

        public FlowObject GetRightFlowObject()
        {
            return rightObjectNo;
        }

        public FlowObject GetLeftFlowObject()
        {
            return leftObjectYes;
        }

        public void SetPositionNo(Point position)
        {
            this.positionno = new Point(position.X, position.Y);

        }

        public Point GetPositionNo()
        {
            return this.positionno;
        }        

        public void SetPositionYes(Point position)
        {
            this.positionyes = new Point(position.X, position.Y);
        }

        public Point GetPositionYes()
        {
            return positionyes;
        }

        public void SetSize(int width,int height)
        {
            size = new Size(width, height);
            sizeNormal = new Size(width, height); 
        }

        public void SetRadius(int r)
        {
            radius = r;
        }

        public int GetRadius()
        {
            return radius;
        }


        public void SetSizeScaled(int width, int height)
        {
            size = new Size(width, height);
            
        }

        public ObjectType GetObjectType()
        {
            return typeofObject;
        }

        public Size GetNormalSize()
        {
            return sizeNormal;
        }

        public Size GetSize()
        {
            return size;
        }

        public void SetPosition(int x,int y)
        {
            position = new Point(x, y);
        }

        public Point GetPosition()
        {
            return position;                
        }

        public void SetBrushColor(Brush brush)
        {
            this.brushcolor = brush;
        }

        public Brush GetBrush()
        {
            return brushcolor;
        }

        public void GoHighLight()
        {
            bHighLight = true;
        }

        public void GoNormal()
        {
            bHighLight = false;
        }

        public void SetHoverPenStyle(Brush brush, float width)
        {
            this.hoverpen = new Pen(brush, width);
        }

        public Pen GetHoverPenStyle()
        {
            return this.hoverpen;
        }

        public void SetPenStyle(Brush brush ,float width)
        {
            this.pen = new Pen(brush, width);
        }

        public Pen GetPenStyle()
        {
            Pen pen = null;
            if (bHighLight)
            {
                pen = new Pen(hoverpen.Brush, hoverpen.Width);
            }else
            {
                pen = this.pen;

            }

            return pen;
        }

        public void SetValue(String val)
        {
            this.val = val;
        }

        public String GetValue()
        {
            return val;
        }

        public   String GetDataType()
        {
            return datatype;
        }

        public void SetDataType(String type)
        {
            datatype = type;
        }



        public void SetSubType(SubType subtype)
        {
            this.subtype = subtype;
        }

        public SubType GetSubType()
        {
            return subtype;
        }

    }
}
