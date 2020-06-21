﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
  partial class Form1
  {
    private void Form1_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tbControl = new TabControl();
      this.tbTask1 = new TabPage();
      this.txtBox = new TextBox();
      this.btnRemove = new Button();
      this.btnAdd = new Button();
      this.comboBox1 = new ComboBox();
      this.tbTask2 = new TabPage();
      this.txtBoxResult = new TextBox();
      this.button1 = new Button();
      this.tbControl.SuspendLayout();
      this.tbTask1.SuspendLayout();
      this.tbTask2.SuspendLayout();
      this.SuspendLayout();
      this.tbControl.Controls.Add((Control) this.tbTask1);
      this.tbControl.Controls.Add((Control) this.tbTask2);
      this.tbControl.Location = new Point(12, 12);
      this.tbControl.Name = "tbControl";
      this.tbControl.SelectedIndex = 0;
      this.tbControl.Size = new Size(380, 239);
      this.tbControl.TabIndex = 0;
      this.tbTask1.Controls.Add((Control) this.txtBox);
      this.tbTask1.Controls.Add((Control) this.btnRemove);
      this.tbTask1.Controls.Add((Control) this.btnAdd);
      this.tbTask1.Controls.Add((Control) this.comboBox1);
      this.tbTask1.Location = new Point(4, 22);
      this.tbTask1.Name = "tbTask1";
      this.tbTask1.Padding = new Padding(3);
      this.tbTask1.Size = new Size(372, 213);
      this.tbTask1.TabIndex = 0;
      this.tbTask1.Text = "Завдання 1";
      this.tbTask1.UseVisualStyleBackColor = true;
      this.txtBox.BackColor = Color.Coral;
      this.txtBox.Location = new Point(6, 9);
      this.txtBox.Name = "txtBox";
      this.txtBox.Size = new Size(121, 20);
      this.txtBox.TabIndex = 3;
      this.btnRemove.ForeColor = Color.Goldenrod;
      this.btnRemove.Location = new Point(247, 6);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new Size(75, 23);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Видалити";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new EventHandler(this.btn_Click);
      this.btnAdd.ForeColor = Color.DarkSlateBlue;
      this.btnAdd.Location = new Point(152, 6);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(75, 23);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Додати";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new EventHandler(this.btn_Click);
      this.comboBox1.BackColor = Color.Chocolate;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(6, 43);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(121, 21);
      this.comboBox1.TabIndex = 0;
      this.tbTask2.Controls.Add((Control) this.txtBoxResult);
      this.tbTask2.Location = new Point(4, 22);
      this.tbTask2.Name = "tbTask2";
      this.tbTask2.Padding = new Padding(3);
      this.tbTask2.Size = new Size(372, 213);
      this.tbTask2.TabIndex = 1;
      this.tbTask2.Text = "Завдання 2";
      this.tbTask2.UseVisualStyleBackColor = true;
      this.txtBoxResult.BackColor = Color.LawnGreen;
      this.txtBoxResult.Location = new Point(119, 174);
      this.txtBoxResult.Name = "txtBoxResult";
      this.txtBoxResult.Size = new Size(147, 20);
      this.txtBoxResult.TabIndex = 0;
      this.button1.Location = new Point(30, 23);
      this.button1.Name = "button1";
      this.button1.Size = new Size(40, 20);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(636, 399);
      this.Controls.Add((Control) this.tbControl);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.tbControl.ResumeLayout(false);
      this.tbTask1.ResumeLayout(false);
      this.tbTask1.PerformLayout();
      this.tbTask2.ResumeLayout(false);
      this.tbTask2.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}