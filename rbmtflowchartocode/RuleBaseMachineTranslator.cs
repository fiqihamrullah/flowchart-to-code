using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rbmtflowchartocode
{
    class RuleBaseMachineTranslator
    {
        private Diagram diagram;
        private Stack<string> stackdatatipe;
        private Dictionary<string,string> dictTipeData;
    

        public RuleBaseMachineTranslator(Diagram diagram)
        {
            this.diagram = diagram;
            stackdatatipe = new Stack<string>();
            dictTipeData = new Dictionary<string, string>();



        }

        private  Stack<String> Reverse(Stack<String> input)
        {
            
            Stack<String> temp = new Stack<String>();
            
            while (input.Count != 0)
                temp.Push(input.Pop());

            return temp;
        }

        private String GeneratePseudocode(FlowObject flowobject, String strpseudo,ref bool  bStartProgram,ref bool bConditional)
        {
            Stack<string> tempdatatype = new Stack<string>();
            if (flowobject.GetObjectType() == ObjectType.RoundRect)
            {
                if (bStartProgram)
                {
                    strpseudo += "[START]|";
                    strpseudo += "BEGINPROGRAM";
                }
                else
                {
                    if (bConditional)
                    {
                        bConditional = false;
                        strpseudo += "|END|";
                    }
                    strpseudo += "ENDPROGRAM";
                }
                bStartProgram = false;

                //  continue;
            }
            else if (flowobject.GetObjectType() == ObjectType.Parallelogram)
            {

                if (flowobject.GetSubType() == SubType.Input)
                {
                    strpseudo += "READ " + flowobject.GetValue();// +"|";
                    System.Diagnostics.Trace.WriteLine("POPx:" + flowobject.GetDataType());
                    tempdatatype.Push(flowobject.GetDataType());
                    dictTipeData.Add(flowobject.GetValue(), flowobject.GetDataType());
                }
                else if (flowobject.GetSubType() == SubType.Output)
                {
                    //cek hash 
                    strpseudo += "PRINT " + flowobject.GetValue();// +"|";
                }
                if (bConditional)
                {
                    bConditional = false;
                    strpseudo += "|END|";
                }
                //strpseudo += "str <- \"" + flowobject.getValue() + "\"|";

            }
            else if (flowobject.GetObjectType() == ObjectType.Rectangle)
            {

                strpseudo += flowobject.GetValue();// +"|";
                if (bConditional)
                {
                    bConditional = false;
                    strpseudo += "|END|";
                }

            }
            else if (flowobject.GetObjectType() == ObjectType.Diamond || flowobject.GetObjectType() == ObjectType.DiamondEllipse)
            {                 
                if (flowobject.GetSubType() == SubType.Loop)
                {
                    String[] arrparse = flowobject.GetValue().Split(new string[] { "<",">","==",">=","<="}, StringSplitOptions.RemoveEmptyEntries);
                    String myvar = "", myval = "";
                    if (arrparse.Length > 1)
                    {
                        myvar = arrparse[0]; myval = arrparse[1];
                        strpseudo += "READ" + myval + " |";
                        tempdatatype.Push("int");
                    }
                    strpseudo += "while (" + flowobject.GetValue() + ")|";
                }
                else if (flowobject.GetSubType() == SubType.Conditional) 
                {
                   strpseudo += "if (" + flowobject.GetValue() + ") THEN|";
                   strpseudo += "BEGIN";
                   bConditional = true;
                }



                if (flowobject.leftObjectYes != null)
                {
                
                    strpseudo += "|";
                    strpseudo = GeneratePseudocode(flowobject.leftObjectYes, strpseudo, ref bStartProgram, ref bConditional);
                }


                if (flowobject.rightObjectNo!= null)
                {
                    if (flowobject.GetObjectType() == ObjectType.Diamond)
                    {
                        strpseudo += "else|";
                    }

                    strpseudo += "BEGIN";
                    bConditional = true;

                    strpseudo += "|"; 
                   strpseudo = GeneratePseudocode(flowobject.rightObjectNo, strpseudo, ref bStartProgram, ref bConditional);
                }

               // strpseudo += "| else | ";
               

            }

            while (tempdatatype.Count > 0 )
            {
               
                String str = tempdatatype.Pop();
                System.Diagnostics.Trace.WriteLine("POP:" + str);
                stackdatatipe.Push(str);
            }
            return strpseudo;
        }

        public String CreatePseudoCode()
        {
            String strpseudo = "[INCLUDE]|";

            bool bConditional = false;
            bool bStartProgram = true;
            for (int i = 0; i < diagram.GetObjectCount(); i++)
            {
                FlowObject flowobject = diagram.GetObjects(i);
                strpseudo = GeneratePseudocode(flowobject, strpseudo, ref bStartProgram,ref bConditional);
                strpseudo += "|";

            }           
         return strpseudo;

        }

        public String Translate(String pseudocode)
        {
                String result = "";
                stackdatatipe = Reverse(stackdatatipe);
                String[] strparse = pseudocode.Split(new char[] { '|' });
                for (int i = 0; i < strparse.Length; i++)
                {
                    if (strparse[i].Trim().Length != 0)
                    {
                        if (strparse[i] == "[INCLUDE]")
                        {
                            result = "#include<stdio.h>\n\n";
                        }
                        else if (strparse[i] == "[START]")
                        {
                            result += "int main()\n";
                        }
                        else if (strparse[i] == "BEGINPROGRAM" || strparse[i] == "BEGIN")
                        {
                            result += "{\n";
                        }
                        else if (strparse[i] == "ENDPROGRAM")
                        {
                            result += "return 0;\n";
                            result += "}\n";
                        }
                        else if (strparse[i] == "END")
                        {
                            result += "}\n";
                        }
                        else
                        {
                            bool bThen = false;
                       // System.Diagnostics.Trace.WriteLine("Berhasil " + strparse[i]);
                            String[] subparse = strparse[i].Split(new char[] { ' ' });
                            if (subparse[0] == "PRINT")
                            {

                                bool ada = dictTipeData.ContainsKey(subparse[1]);
                                if (ada)
                                {
                                    String tipedata = dictTipeData[subparse[1]];
                                    if (tipedata == "int")
                                    {
                                        result += "printf(\"%d\",&" + subparse[1] + ")";
                                    }
                                    else if (tipedata == "float")
                                    {
                                        result += "printf(\"%f\",&" + subparse[1] + ")";
                                    }
                                    else if (tipedata == "double")
                                    {
                                        result += "printf(\"%lf\",&" + subparse[1] + ")";
                                    }else if (tipedata == "char")
                                    {
                                       result += "printf(" + subparse[1] + ")";
                                    }

                            }
                               else
                                {
                                    result += "printf(" + subparse[1];
                                    for (int xx = 2; xx < subparse.Length; xx++)
                                    {
                                        result += " " + subparse[xx];
                                    }
                                    result += ")";
                                }


                            }
                            else if (subparse[0] == "READ")
                            {

                                string tipedata = stackdatatipe.Pop();
                               // System.Diagnostics.Trace.WriteLine("POP:" + tipedata);
                               // System.Diagnostics.Trace.WriteLine("data " + subparse[1]);
                                if (tipedata == "char")
                                {
                                    result += tipedata + " " + subparse[1] + "[100];\n";
                                }
                                else {
                                    result += tipedata + " " + subparse[1] + ";\n";
                                }
                                
                                if(tipedata == "char")
                               {
                                    result += "gets(" + subparse[1] + ")";
                                }
                                else if (tipedata == "int")
                                {
                                    result += "scanf(\"%d\",&" + subparse[1] + ")";
                                }
                                else if (tipedata == "float")
                                {
                                    result += "scanf(\"%f\",&" + subparse[1] + ")";
                                }
                                else if (tipedata == "double")
                                {
                                    result += "scanf(\"%lf\",&" + subparse[1] + ")";
                                }
                                
                                /*string tipedata = FlowObject.gettipedata();
                                result += tipedata + " " + subparse[1];*/
                            
                            }
                            else
                            {
                                int exist = strparse[i].IndexOf("THEN");
                                if (exist > 0)
                                {
                                    bThen = true;
                                    strparse[i] = strparse[i].Replace("THEN", "");
                                }

                                exist = strparse[i].IndexOf("while");
                                if (exist >= 0)
                                {
                                    bThen = true;

                                }

                                exist = strparse[i].IndexOf("else");
                                if (exist >= 0)
                                {
                                    bThen = true;

                                }


                            String[] arrparse = strparse[i].Split(new string[] { "<-" }, StringSplitOptions.RemoveEmptyEntries);
                                String myvar = "", myval = "";
                                if (arrparse.Length > 1)
                                {
                                    myvar = arrparse[0]; myval = arrparse[1];
                                    result += myvar + " = " + myval;
                                }
                            else
                                {
                                    result += strparse[i];
                                }

                           

                        }
                            if (bThen == false)
                            {
                                result += ";\n";
                            }
                        }
                    }
                }

                return result;           
        }

    }
}
