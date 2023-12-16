using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rbmtflowchartocode
{
    enum ObjectType { RoundRect, Parallelogram, Rectangle, Diamond,DiamondEllipse,None};
    class Selector
    {

        ObjectType selectedObjectType;

        public Selector( )
        {
            
        }



        public void SelectObjectType(ObjectType selectedObjectType)
        {
            this.selectedObjectType = selectedObjectType;
        }


        public ObjectType GetSelectedObjectType()
        {
            return selectedObjectType;
        }

    }
}
