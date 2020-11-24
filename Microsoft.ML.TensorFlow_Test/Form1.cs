﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using OpenCvSharp;
using OpenCvSharp.Dnn;
using OpenCvSharp.Extensions;
using Keras;
using Python;
using Python.Runtime;

namespace Microsoft.ML.TensorFlow_Test
{
    public partial class Form1 : Form
    {
        //DirectoryInfo mediaDIR = new DirectoryInfo(Program.mediaPath);
        private string mediaPath = Program.currentPath + "\\" + Program.mediaPath;
        private string prototxtPath = Program.currentPath + "\\" + Program.prototxtPath;
        private string caffemodelPath = Program.currentPath + "\\" + Program.caffemodelPath;
        private string maskdetectorPath = Program.currentPath + "\\" + Program.maskdetectorPath;


        public Form1()
        {
            var net = CvDnn.ReadNetFromCaffe(prototxtPath, caffemodelPath);
            var model = Keras.Models.Model.LoadModel(maskdetectorPath);
            InitializeComponent();
            Console.WriteLine(mediaPath);
            Console.WriteLine(prototxtPath);
            Console.WriteLine(caffemodelPath);
            Console.WriteLine(maskdetectorPath);
            Console.WriteLine(System.Windows.Forms.Application.StartupPath);
        }

        private void pictureBoxIpl1_Click(object sender, EventArgs e)
        {

        }
    }
}
