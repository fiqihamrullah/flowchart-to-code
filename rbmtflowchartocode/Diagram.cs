using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rbmtflowchartocode
{
    class Diagram
    {
        private List<FlowObject> flowobjects;

        public  Diagram()
        {
            flowobjects = new List<FlowObject>();
        }

        public void AddObject(FlowObject flowobject)
        {
           
            flowobjects.Add(flowobject);
           
            if (flowobjects.Count > 1)
            {
                flowobject.UpperObject = flowobjects[GetObjectCount() - 2];
            } 
              
        }



        public void AddObject(FlowObject afterobject,FlowObject flowobject)
        {
            int idx = flowobjects.IndexOf(afterobject);
            if (idx!=flowobjects.Count-1)
            {
                flowobject.UpperObject = flowobjects[idx];
                flowobjects.Insert(idx + 1, flowobject);
            }
           

        }



        public bool IsValid()
        {
            bool bValid = false;

            if (GetObjectCount() > 1)
            {
                if (flowobjects[0].GetObjectType() == ObjectType.RoundRect && flowobjects[GetObjectCount() - 1].GetObjectType() == ObjectType.RoundRect)
                {
                    bValid = true;
                }
            }
            return bValid;
        }

        public FlowObject GetObjects(int idx)
        {
            return flowobjects[idx];
        }

        public void Remove(FlowObject flowobject)
        {
            flowobjects.Remove(flowobject);
        }

        public void ClearObject()
        {
            flowobjects.Clear();
        }

        public int GetObjectCount()
        {
            return flowobjects.Count;
        }

    }
}
