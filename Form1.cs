using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace simple_py_exec

{
    public partial class Form1 : Form
    {
        public bool all_ok = true;

        public Form1()
        {
            InitializeComponent();
        }

        public string Generate_cmd(bool no_error=true)
        {
            string arguments = " ";
            string restult_txt = "";

            if (arg1.Text == "" && no_error == false){
                MessageBox.Show("URL vide!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
                all_ok = false;
            }
            else if (arg1.Text != ""){
                arguments = arguments + "-u " + arg1.Text;
            }
            if (arg2.Text != ""){
                arguments = arguments + " -db " + arg2.Text;
            }
            if (arg3.Text != ""){
                arguments = arguments + " -m" + arg3.Text;
            }
            if (arg4.Text != ""){
                arguments = arguments + " -xm" + arg4.Text;
            }
            if (arg5.Text != ""){
                arguments = arguments + " -to" + arg5.Text;
            }
            if (arg6.Text != "") {
                arguments = arguments + " -tn" + arg6.Text;
            }

            if (python_path.Text != "")
            {
                simple_py_exec.Properties.Settings.Default.python_path = python_path.Text;
                restult_txt = restult_txt + " " + python_path.Text;
            }
            if (py_path.Text != "")
            {
                restult_txt = restult_txt + " " + py_path.Text;
            }
            restult_txt = restult_txt + arguments;
            result.Text = restult_txt;

            simple_py_exec.Properties.Settings.Default.Save();
            return restult_txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = Generate_cmd(false);

            if (cmd != "")
            {
                System.Diagnostics.Process.Start("CMD.exe", "/K " + cmd);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate_cmd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            python_path.Text = simple_py_exec.Properties.Settings.Default.python_path;
        }
    }
}
