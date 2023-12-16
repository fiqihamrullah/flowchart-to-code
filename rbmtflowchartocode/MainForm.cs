using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace rbmtflowchartocode
{
    public partial class MainForm : Form
    {
        private Selector selector;
        private FlowChartDrawer fcd;
        private Diagram diagram;
        private DiagramMapper diagrammapper;

        private bool bDelete;
        private bool bDiamond;
        private int pil = -1;

        public MainForm()
        {
            InitializeComponent();

            selector = new Selector();
          //  fcd = new FlowChartDrawer(splitContainer2.Panel2.CreateGraphics(), diagram);
            diagram = new Diagram();
            diagrammapper = new DiagramMapper(diagram, splitContainer2.Panel2);
            bDelete = false;
            bDiamond = false;

            newDiagramDocument();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            splitContainer2.Panel2, new object[] { true });


        }

        private void Init()
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(splitContainer2.Panel2.AutoScrollPosition.X, splitContainer2.Panel2.AutoScrollPosition.Y);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 300, 2000);

            fcd = new FlowChartDrawer(e.Graphics, diagram, diagrammapper.GetRatio());
            fcd.PaintDiagram();
        }

        private void tsbtnRectangle_Click(object sender, EventArgs e)
        {
            //choose process symbol
            selector.SelectObjectType(ObjectType.Rectangle);
            
        }

        private void newDiagramDocument()
        {
            diagram.ClearObject();

            selector.SelectObjectType(ObjectType.RoundRect);
            FlowObject flowobject = FlowChartObjectProducer.Create(selector, SubType.Other);
            diagram.AddObject(flowobject);       
    
            flowobject = FlowChartObjectProducer.Create(selector, SubType.Other);
            diagram.AddObject(flowobject);
            diagrammapper.MapObject();
            splitContainer2.Panel2.Invalidate();
        }

        private void tsBtnRoundRect_Click(object sender, EventArgs e)
        {
            //choose startend symbol
            newDiagramDocument();

        }

        private void tsbtnParalellogram_Click(object sender, EventArgs e)
        {
            //choose io symbol
            selector.SelectObjectType(ObjectType.Parallelogram);
            pil = 1;
          
        }

        private void tsbtndiamond_Click(object sender, EventArgs e)
        {
            //choose decision symbol
            selector.SelectObjectType(ObjectType.Diamond);
           
            
           
             
        }

        private void tsbtnexecute_Click(object sender, EventArgs e)
        {
            if (diagram.GetObjectCount() > 0)
            {
                if (diagram.IsValid())
                {
                    RuleBaseMachineTranslator rbmt = new RuleBaseMachineTranslator(diagram);
                    String pseudocode = rbmt.CreatePseudoCode();
                    System.Diagnostics.Trace.WriteLine(pseudocode);
                    String result = rbmt.Translate(pseudocode);
                    pseudocode = pseudocode.Replace("|", "\n");

                    rtbPseudoCode.Text = pseudocode;
                    rtbHasil.Text = result;
                }
                else
                {
                    MessageBox.Show("Diagram Tidak Valid!", "Gagal Translasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tidak Ada Diagram Sama Sekali!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void splitContainer2_Panel2_SizeChanged(object sender, EventArgs e)
        {
            if (diagrammapper != null)
            {
                diagrammapper.MapObject();
                splitContainer2.Panel2.Invalidate();
            }
        }



        private void splitContainer2_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            FlowObject flowobject = diagrammapper.GetFlowObject(e.X, e.Y);          

            if (bDelete)
            {
                if (flowobject.GetObjectType() != ObjectType.RoundRect)
                {
                    diagram.Remove(flowobject);
                    diagrammapper.MapObject();
                    splitContainer2.Panel2.Invalidate();
                }
                bDelete = false;
            }
            else
            {
                if (selector.GetSelectedObjectType() == ObjectType.None  && flowobject!=null)
                {
                    FormDialogInput frmDialog = new FormDialogInput();
                   
                        if (flowobject.GetObjectType() == ObjectType.Parallelogram)
                        {
                            if (flowobject.GetSubType() == SubType.Input)
                            {
                                frmDialog.Init("Menentukan Nilai Input", "Masukkan Nilai :");
                                frmDialog.PrepareInput(flowobject.GetDataType(), flowobject.GetValue());
                            }
                            else if (flowobject.GetSubType() == SubType.Output)
                            {
                                frmDialog.Init("Menentukan Nilai Output", "Masukkan Nilai :");
                            }
                            frmDialog.ShowDialog();


                        }
                        else if (flowobject.GetObjectType() == ObjectType.Diamond || flowobject.GetObjectType() == ObjectType.DiamondEllipse)
                        {
                            frmDialog.Init("Menentukan Kondisi", "Masukkan Kondisi :");
                            frmDialog.ShowDialog();
                        }
                        else if (flowobject.GetObjectType() == ObjectType.Rectangle)
                        {
                            frmDialog.Init("Menentukan Perintah/Assignment", "Masukkan Perintah/Assignment :");

                            String[] arrparse = flowobject.GetValue().Split(new string[] { "<-" }, StringSplitOptions.RemoveEmptyEntries);
                            String myvar = "", myval = "";
                            if (arrparse.Length > 1)
                            {
                                myvar = arrparse[0]; myval = arrparse[1];
                            }
                            frmDialog.PrepareProcessInput(myvar, myval);
                            frmDialog.ShowDialog();
                        }

                        if (!frmDialog.GetInput().Equals(""))
                        {

                            String data = frmDialog.GetInput();
                            if (flowobject.GetObjectType() == ObjectType.Rectangle)
                            {
                                String myvar = frmDialog.GetVarInput();
                                data = myvar + "<-" + data;
                            }
                            flowobject.SetValue(data);
                        }

                        if (!frmDialog.getinputtipe().Equals(""))
                        {
                            String tipedata = frmDialog.getinputtipe();
                            flowobject.SetDataType(tipedata);

                        }
                     
                    diagrammapper.MapObject();
                    frmDialog.Dispose();
                    splitContainer2.Panel2.Invalidate();
                }else
                {
                    FlowObject newflowobject = null;
                    if (selector.GetSelectedObjectType()==ObjectType.Parallelogram )
                    {
                        if (pil == 1)
                        {
                            newflowobject = FlowChartObjectProducer.Create(selector, SubType.Input);
                        }
                        else if (pil == 2)
                        {
                            newflowobject = FlowChartObjectProducer.Create(selector, SubType.Output);
                        } 
                    }else if (selector.GetSelectedObjectType() == ObjectType.Rectangle)
                    {
                        newflowobject = FlowChartObjectProducer.Create(selector, SubType.Other);
                    }
                    else if (selector.GetSelectedObjectType() == ObjectType.Diamond)
                    {
                        newflowobject = FlowChartObjectProducer.Create(selector, SubType.Conditional);
                    }
                    else if (selector.GetSelectedObjectType() == ObjectType.DiamondEllipse)
                    {
                        newflowobject = FlowChartObjectProducer.Create(selector, SubType.Loop);
                    }

                    if (flowobject != null)
                    {

                        if (flowobject.GetObjectType() == ObjectType.Diamond)
                        {
                            if (diagrammapper.IsRightPosition())
                            {
                                flowobject.SetRightFlowObject(newflowobject);
                            }
                            else if (diagrammapper.IsLeftPosition())
                            {
                                flowobject.SetLeftFlowObject(newflowobject);
                            }
                            else
                            {
                                diagram.AddObject(flowobject, newflowobject);
                            }
                        }
                        else if (flowobject.GetObjectType() == ObjectType.DiamondEllipse)
                        {
                            if (diagrammapper.IsRightPosition())
                            {
                                flowobject.SetRightFlowObject(newflowobject);
                            }
                            else
                            {
                                diagram.AddObject(flowobject, newflowobject);
                            }
                        }
                        else
                        {
                            diagram.AddObject(flowobject, newflowobject);
                        }


                        diagrammapper.MapObject();
                        splitContainer2.Panel2.Invalidate();
                    }
                }
            }
            selector.SelectObjectType(ObjectType.None);
        }
 

        private void toolstripbtnremove_Click(object sender, EventArgs e)
        {
            bDelete = true;
        }

        private void tsBtnDiamondEllipse_Click(object sender, EventArgs e)
        {
            selector.SelectObjectType(ObjectType.DiamondEllipse);
        }
            

        private void splitContainer2_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            FlowObject flowobject = diagrammapper.GetFlowObject(e.X, e.Y);
            if (flowobject != null)
            {
                flowobject.GoHighLight();
                splitContainer2.Panel2.Invalidate();
                
            }
        }

        private void tsbtnoutput_Click(object sender, EventArgs e)
        {
            selector.SelectObjectType(ObjectType.Parallelogram);
            pil = 2;
        }
    }
}
