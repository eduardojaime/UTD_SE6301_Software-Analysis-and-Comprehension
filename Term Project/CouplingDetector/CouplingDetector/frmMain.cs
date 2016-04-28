using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ABB.SrcML;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace CouplingDetector
{
    public partial class frmMain : Form
    {
        SrcML srcMLCommand = new SrcML();
        Src2SrcMLRunner src2srcML = new Src2SrcMLRunner();
        SrcML2SrcRunner srcML2src = new SrcML2SrcRunner();

        public frmMain()
        {
            InitializeComponent();
            txtXMLPath.Text = @"C:\Users\Eduardo Jaime\Desktop\Projecto SAC\Source\json.xml";
            txtXMLPath.Text = @"C:\Users\Eduardo Jaime\Desktop\mytest.xml";
            chkCoupling.Checked = true;
        }

        // Source to srcML
        private void rbFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFolder.Checked) { txtFolderPath.Enabled = true; btnOpenFolder.Enabled = true; }
            else { txtFolderPath.Enabled = false; btnOpenFolder.Enabled = false; }
        }

        private void rbFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFile.Checked) { txtFilePath.Enabled = true; btnOpenFile.Enabled = true; }
            else { txtFilePath.Enabled = false; btnOpenFile.Enabled = false; }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            diaFolder.Description = "Select the folder where your source code is located:";
            DialogResult dgResult = diaFolder.ShowDialog();
            if (dgResult == DialogResult.OK)
            {
                txtFolderPath.Text = diaFolder.SelectedPath;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            diaFile.Title = "Select a file individually for conversion:";
            diaFile.FileName = "Source File";
            diaFile.Filter = "C# (*.cs)|*.cs|VB.NET (*.vb)|*.vb|Java (*.java)|*.java";
            DialogResult drResult = diaFile.ShowDialog();
            if (drResult == DialogResult.OK)
            {
                txtFilePath.Text = diaFile.FileName;
            }
        }

        private void btnSource2srcML_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbFolder.Checked)
                {
                    if (txtFolderPath.Text != "")
                    {
                        srcMLCommand.GenerateSrcMLFromDirectory(txtFolderPath.Text, "test2.xml", Language.CSharp);
                        MessageBox.Show("SrcML XML File generated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Please choose a folder to convert.");
                    }
                }
                else {
                    if (txtFilePath.Text != "")
                    {
                        srcMLCommand.GenerateSrcMLFromFile(txtFilePath.Text, "test2.xml", Language.CSharp);
                        MessageBox.Show("SrcML XML File generated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Please choose a file to convert.");
                    }
                }
            }
            catch (Exception ex) { }
        }

        // srcML to Source
        private void convert() { }

        // Code Analyser
        private void btnOpenXML_Click(object sender, EventArgs e)
        {
            diaFile.Title = "Select a srcML XML File to analyse:";
            diaFile.FileName = "srcML File";
            diaFile.Filter = "srcML File (*.xml)|*.xml";
            DialogResult drResult = diaFile.ShowDialog();
            if (drResult == DialogResult.OK)
            {
                txtXMLPath.Text = diaFile.FileName;
                //MessageBox.Show("XML File loaded successfully.");
            }
        }

        private void btnCustomQuery_Click(object sender, EventArgs e)
        {
            try
            {
                String sXPathExpression = txtCustomQuery.Text;
                StringBuilder sbResults = new StringBuilder();
                if (sXPathExpression == "" || txtXMLPath.Text == "")
                {
                    if (txtXMLPath.Text == "")
                    {
                        MessageBox.Show("Please select the file to analyse.");
                    }
                    if (sXPathExpression == "")
                    {
                        MessageBox.Show("Please specify an XPath expression.");
                    }
                }
                else {
                    txtResults.Text = "";

                    XPathNodeIterator nodeIter = getIterator(txtXMLPath.Text, sXPathExpression);
                    while (nodeIter.MoveNext())
                    {
                        sbResults.AppendLine("Result : " + nodeIter.Current.Value);
                    }
                    txtResults.Text = (sbResults.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnScanDocument_Click(object sender, EventArgs e)
        {

            txtResults.Text = "";

            if (txtXMLPath.Text == "")
            {
                // SrcMLFile srcFile = new SrcMLFile(txtFilePath.Text);
                //srcFile.
                MessageBox.Show("Please select the file to analyse.");
            }
            else {
                if (chkCoupling.Checked)
                {
                    detectCouplingMethod();
                }
            }
        }

        private void detectCouplingMethod()
        {
            try
            {
                String sXMLRootValue = @"<?xml version=""1.0"" encoding=""UTF - 8"" standalone=""yes""?>";

                // First get all the Units
                String sGetUnitExpression = "//src:unit";
                String sGetFieldDeclarations = "//src:class/src:block/src:decl_stmt/src:decl/src:name";
                String sGetFieldUses = "//src:function[descendant::src:name='{0}']/src:name";
                StringBuilder sbResults = new StringBuilder();

                Boolean bFileAdded = false;
                String sCurrentFileName = "";

                XPathNodeIterator nodeIterator = getIterator(txtXMLPath.Text, sGetUnitExpression);
                while (nodeIterator.MoveNext())
                {
                    String sUnitOuterXML = sXMLRootValue + nodeIterator.Current.OuterXml;
                    // Get the XML Of the current unit
                    StringReader sUnitXML = new StringReader(sUnitOuterXML);

                    // Get Filename
                    XPathNodeIterator iterFilename = getIterator(sUnitXML, "//src:unit/@filename");
                    while (iterFilename.MoveNext()) sCurrentFileName = iterFilename.Current.Value; //sbResults.AppendLine("Filename : " + iterFilename.Current.Value);

                    // Get Field Declarations
                    sUnitXML = new StringReader(sUnitOuterXML);
                    XPathNodeIterator iterFieldName = getIterator(sUnitXML, sGetFieldDeclarations);
                    while (iterFieldName.MoveNext())
                    {
                        int iTimesUsed = 0;
                        String sFieldName = iterFieldName.Current.Value;

                        String sMethods = "";
                        sUnitXML = new StringReader(sUnitOuterXML);
                        XPathNodeIterator iterMethodName = getIterator(sUnitXML, String.Format(sGetFieldUses, sFieldName));
                        while (iterMethodName.MoveNext())
                        {
                            if (bFileAdded == false)
                            {
                                bFileAdded = true;
                                sbResults.AppendLine("Filename : " + iterFilename.Current.Value);
                            }
                            String sMethodName = iterMethodName.Current.Value;
                            if (sMethodName != "set")
                            {
                                if (sMethodName != "get")
                                {
                                    iTimesUsed++;
                                    sMethods += sMethodName + ", ";
                                }
                            }
                        }
                        if (sMethods != "" && iTimesUsed > 1) sbResults.AppendLine(String.Format("The field {0} is being used in the methods: {1}.", sFieldName, sMethods));
                    }
                    sbResults.AppendLine("");
                    bFileAdded = false;
                }
                txtResults.Text = (sbResults.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void methodo()
        {/*
            // Create a reader for each unit;
            XPathNodeIterator iterUnits = getIterator(sUnitXML, "//src:unit/@filename");


            StringReader sUnitXML2 = new StringReader(sXMLRootValue + nodeIterator.Current.OuterXml);
            XPathNodeIterator iterMethods = getIterator(sUnitXML2, "//src:function_decl/src:name");
            while (iterMethods.MoveNext())
            {
                sbResults.AppendLine("Method : " + iterMethods.Current.Value);
            }*/
        }

        private XPathNodeIterator getIterator(String XPathDocument, String XPathExpression)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            docNav = new XPathDocument(XPathDocument);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            XPathExpression query = nav.Compile(XPathExpression);

            XmlNamespaceManager manager = new XmlNamespaceManager(nav.NameTable);
            manager.AddNamespace("src", "http://www.srcML.org/srcML/src");
            query.SetContext(manager);

            NodeIter = nav.Select(query);

            return NodeIter;
        }
        private XPathNodeIterator getIterator(StringReader XPathDocument, String XPathExpression)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            docNav = new XPathDocument(XPathDocument);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();


            XPathExpression query = nav.Compile(XPathExpression);
            XmlNamespaceManager manager = new XmlNamespaceManager(nav.NameTable);
            manager.AddNamespace("src", "http://www.srcML.org/srcML/src");
            query.SetContext(manager);

            NodeIter = nav.Select(query);

            return NodeIter;
        }
    }
}
