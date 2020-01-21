using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace surprise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoStart();
        }
       ///只要改字段存在就会导致程序没有关闭选项（显然这不是我们想要的）
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int CS_NOCLOSE = 0x200; 
        //        CreateParams cp = base.CreateParams; 
        //        cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE; 
        //        return cp;
        //    }
        //}
        private void AutoStart(bool isAuto = true, bool showinfo = true)
        {
            try
            {
                if (isAuto == true)
                {
                    RegistryKey R_local = Registry.CurrentUser;//RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("应用名称", Application.ExecutablePath);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    RegistryKey R_local = Registry.CurrentUser;//RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue("应用名称", false);
                    R_run.Close();
                    R_local.Close();
                }
            }
            catch (Exception)
            {
                if (showinfo)
                    MessageBox.Show("您需要管理员权限修改", "提示");
            }
        }
        bool booltemp = false;
        double aa = 0.00;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!booltemp)
            {
                booltemp = true;
                MessageBox.Show("AAA");
                e.Cancel = true;
            }
            else
            {
                int height = Screen.PrimaryScreen.Bounds.Height/2;
                int width = Screen.PrimaryScreen.Bounds.Width/2;
                Random rd = new Random();

                aa = 2 * Math.PI*rd.NextDouble();
                //if (aa> 2*Math.PI)
                //{
                //    aa -= 2 * Math.PI;
                //}
                double r = 100;
                this.Location = new Point(width + Convert.ToInt32(Math.Cos(aa) * r),height+ Convert.ToInt32(Math.Sin(aa) * r));
                e.Cancel = true;
                label1.Text = "点不到我哦";
            }



        }

        string[] vsList3 = new string[] { "真的这么想要关掉吗？", "2", "3", "4", "5" };
        string[] vsList4 = new string[] { "哈哈", "4", "3", "2", "1" };
        string[] vsList1 = new string[] { "1", "2", "3", "4", "5" };
        string[] vsList2 = new string[] { "5", "4", "3", "2", "1" };
        int index=0;
        int index2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index==vsList1.Length)
            {
                index = 0;
                if (MessageBox.Show("所谓缘妙不可言，真的想关掉这个程序吗？", "哈哈", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DateTime dt = new DateTime(2019,10,24,15,48,0);
                    TimeSpan tp=DateTime.Now.Subtract(dt)
                    if (MessageBox.Show("我们已经认识"+tp.TotalDays+"天啦！", "哈哈", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("一起看过电影！", "哈哈", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            if (MessageBox.Show("吃过好吃的^_^。", "哈哈", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                if (MessageBox.Show("一起压过马路。", "哈哈", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    if (MessageBox.Show("我特别喜欢你身上淡淡的香味，和软fufu的小手！", "哈哈", MessageBoxButtons.OK) == DialogResult.OK)
                                    {
                                        if (MessageBox.Show("你成功拯救了一个网瘾少年", "哈哈", MessageBoxButtons.OK) == DialogResult.OK)
                                        {
                                            if (MessageBox.Show("和你相遇让我真正体会到了 ", "哈哈", MessageBoxButtons.OK) == DialogResult.OK)
                                            {

                                            }

                                        }

                                    }
                                }
                            }
                        }
                        else
                        {

                        }

                    }
                    else
                    {

                    }
                }
                else
                { 
                
                }

            }
            button1.Text = vsList1[index];
            button2.Text = vsList2[index];
            index++;
        }
        //private Boolean showsth()
        //{ 
        
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            if (index == vsList1.Length)
            {
                index = 0;
            }
            button1.Text = vsList1[index];
            button2.Text = vsList2[index];
            index++;
        }
    }
}
