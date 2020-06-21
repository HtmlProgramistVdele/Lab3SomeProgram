using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private Button[] btnArray = new Button[16];
        private Random r = new Random();
        private List<int> numbers = new List<int>();
        private int i = 1;
        private IContainer components = (IContainer) null;
        private int rand;
        private TabControl tbControl;
        private TabPage tbTask1;
        private Button btnRemove;
        private Button btnAdd;
        private ComboBox comboBox1;
        private TabPage tbTask2;
        private TextBox txtBox;
        private TextBox txtBoxResult;
        private Button button1;
        public Form1()
        {
            this.InitializeComponent();
            int num1 = 1;
            foreach (Button btn in this.btnArray)
                this.numbers.Add(num1++);
            var num2 = 0;
            var num3 = 0;
            for (var index1 = 1; index1 < this.btnArray.Length + 1; ++index1)
            {
                this.button1 = new Button();
                var button1 = this.button1;
                var num4 = num3;
                var size = this.button1.Size;
                var width = size.Width;
                var x = num4 * width + 60;
                var num5 = (index1 - 1) % 4;
                size = this.button1.Size;
                var height = size.Height;
                var y = num5 * height + 30;
                var point = new Point(x, y);
                button1.Location = point;
                var index2 = this.r.Next(this.numbers.Count - 1);
                this.button1.Name = this.numbers[index2].ToString();
                this.button1.Size = new Size(new Point(40, 20));
                this.button1.Text = this.numbers[index2].ToString();
                this.button1.Click += new EventHandler(this.btnArray_Click);
                this.numbers.RemoveAt(index2);
                num2 = index2 + 1;
                this.btnArray[index1 - 1] = this.button1;
                this.tbTask2.Controls.Add((Control) this.btnArray[index1 - 1]);
                if (index1 % 4 == 0)
                    ++num3;
            }
            int num6 = 1;
            foreach (Button btn in this.btnArray)
                this.numbers.Add(num6++);
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button)?.Name == this.btnAdd.Name)
            {
                if (!(this.txtBox.Text != ""))
                    return;
                this.comboBox1.Items.Add((object) this.txtBox.Text);
                this.txtBox.Text = "";
            }
            else
            {
                if ((uint) this.comboBox1.Items.Count <= 0U)
                    return;
                this.comboBox1.Items.RemoveAt(this.comboBox1.Items.Count - 1);
            }
        }
        
        private void btnArray_Click(object sender, EventArgs e)
        {
            if ((sender as Button)?.Name == this.i.ToString())
            {
                this.txtBoxResult.Text = "";
                ((Button) sender).Visible = false;
                this.numbers.RemoveAt(this.numbers.IndexOf(this.i));
                foreach (Button btn in this.btnArray)
                {
                    if (!btn.Visible) continue;
                    this.rand = this.r.Next(this.numbers.Count);
                    var button1 = btn;
                    var number = this.numbers[this.rand];
                    var str1 = number.ToString();
                    button1.Name = str1;
                    Button button2 = btn;
                    number = this.numbers[this.rand];
                    var str2 = number.ToString();
                    button2.Text = str2;
                    this.numbers.RemoveAt(this.rand);
                }
                for (var index = this.i + 1; index < this.btnArray.Length + 1; ++index)
                    this.numbers.Add(index);
                ++this.i;
            }
            else if (this.i != 1)
                this.ClearNumbers();
            if (this.i != 17)
                return;
            this.txtBoxResult.TextAlign = HorizontalAlignment.Center;
            this.txtBoxResult.Text = "Молодець!!!";
            this.ClearNumbers();
        }
        
        private void ClearNumbers()
        {
            this.numbers.Clear();
            this.i = 1;
            for (int i = this.i; i < this.btnArray.Length + 1; ++i)
                this.numbers.Add(i);
            foreach (Button btn in this.btnArray)
            {
                if (!btn.Visible)
                    btn.Visible = true;
                this.rand = this.r.Next(this.numbers.Count - 1);
                Button button1 = btn;
                int number = this.numbers[this.rand];
                string str1 = number.ToString();
                button1.Name = str1;
                Button button2 = btn;
                number = this.numbers[this.rand];
                string str2 = number.ToString();
                button2.Text = str2;
                this.numbers.RemoveAt(this.rand);
            }
            for (var i = this.i; i < this.btnArray.Length + 1; ++i)
                this.numbers.Add(i);
        }
    }
}